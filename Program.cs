﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LiveEventsSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soc.Connect("127.0.0.1", 34243);
            while (true)
            {
                if (soc.Available > 0)
                {
                    int size = soc.Available;
                    byte[] bytes = new byte[size];
                    soc.Receive(bytes, 0, size,SocketFlags.None);
                    Console.WriteLine(Encoding.UTF8.GetString(bytes));
                }
            }
        }
    }
}
