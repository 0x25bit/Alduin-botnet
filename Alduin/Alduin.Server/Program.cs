using System;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Alduin.Server.Modules;

namespace Alduin.Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Process[] p;
            p = Process.GetProcessesByName("tor");
            if (!(p.Length > 0))
                proccessstart();
            Thread.Sleep(toSec(90));
        }
        private static string MainPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        private static void proccessstart()
        {
            Console.WriteLine("Starting tor...");
            var Process = new Process();
            Process.StartInfo.FileName = GetPathes.get_LocalPath() + @"\Tor\tor.exe";
            Process.StartInfo.Arguments = "-f " + GetPathes.get_LocalPath() + @"\Tor\Data\Tor\torrc";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.StartInfo.WorkingDirectory = GetPathes.get_LocalPath() + @"\Tor";
            Process.Start();
            Process.PriorityClass = ProcessPriorityClass.BelowNormal;
        }
        public static int toSec(int sec)
        {
            return sec * 1000;
        }
        /*public static void Connect(String server, String message)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                NetworkStream stream = client.GetStream();

                int count = 0;
                while (count++ < 3)
                {
                    // Translate the Message into ASCII.
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                    // Send the message to the connected TcpServer. 
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("Sent: {0}", message);

                    // Bytes Array to receive Server Response.
                    data = new Byte[256];
                    String response = String.Empty;

                    // Read the Tcp Server Response Bytes.
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    Console.WriteLine("Received: {0}", response);

                    Thread.Sleep(2000);
                }

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }

            Console.Read();
        }*/
    }
}
