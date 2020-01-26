using System.IO;
using System.Text;

internal static partial class Create
{
    public static void torchfileCreate(string path)
    {
        if (!File.Exists(path + @"\Tor\Data\Tor\torrc"))
        {
            string filestring = @"
ControlPort 9151
DataDirectory " + path + @"\Tor
DirPort 9030
ExitPolicy reject *:*
HashedControlPassword 16:4E1F1599005EB8F3603C046EF402B00B6F74C008765172A774D2853FD4
HiddenServiceDir " + path + @"
HiddenServicePort 80 127.0.0.1:5557
Log notice stdout
Nickname VBMogyiii
SocksPort 9150";
            FileStream fs = File.Create(path + @"\Tor\Data\Tor\torrc");
            var info = new UTF8Encoding(true).GetBytes(filestring);
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}
