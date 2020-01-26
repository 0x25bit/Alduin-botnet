using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Alduin.Server.Modules
{
    internal partial class GetPathes
    {
        private static string MainPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        public static object get_LocalPath()
        {
            string local_path = MainPath.Replace(@"file:\", "");
            return local_path;
        }
    }
}
