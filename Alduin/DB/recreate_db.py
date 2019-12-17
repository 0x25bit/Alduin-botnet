from configparser import ConfigParser
import psycopg2
from psycopg2.extensions import ISOLATION_LEVEL_AUTOCOMMIT

def config(section='postgresql'):
    filename = 'database.ini'
    parser = ConfigParser()
    parser.read(filename)

    db = {}
    if parser.has_section(section):
        params = parser.items(section)
        for param in params:
            db[param[0]] = param[1]
    else:
        print('{0} is not found in the file {1}'.format(section, filename))

    return db

def connect(section, filename):
    conn = None
    try:
        params = config(section)

        schema = open(filename, 'r')
        sql = ''
        if schema.mode == 'r':
            sql = schema.read()

        if len(sql) == 0:
            print('{0} file is empty.'.format(filename))
            return

        print('Connecting to database...')
        conn = psycopg2.connect(**params)

        # conn.set_isolation_level(ISOLATION_LEVEL_AUTOCOMMIT)
        cur = conn.cursor()
        
        print('Executing query...')
        conn.set_isolation_level(0)
        cur.execute(sql)
        conn.commit()
        cur.close()
    except (Exception, psycopg2.DatabaseError) as error:
        print(error)
    finally:
        if conn is not None:
            conn.close()
            print('Session closed.')

if __name__ == '__main__':
    cfgs = [['close', '_CloseConnections.sql'], ['drop', '_DropDB.sql'], ['init', '_InitDB.sql'], ['create', '_CreateSchema.sql']]
    for cfg in cfgs:
        connect(cfg[0], cfg[1])