using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alduin.Server.Modules
{
    internal partial class ReadFile
    {
        private static object filereader(string file)
        {
            return File.ReadAllText(file, Encoding.UTF8);
        }
    }
}
