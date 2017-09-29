using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace baitapTH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ten may: \"{0}\"", Dns.GetHostName());
            IPAddress[] myIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in myIP)
            {
                Console.WriteLine(" IP {0}: {1}", ip.AddressFamily.ToString(), ip.ToString());
            }
            



        }
    }
}
