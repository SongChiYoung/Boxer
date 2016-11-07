using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Boxer
{
    static class Util
    {
        //private static IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        //private static IPAddress ipAddr = ipHost.AddressList[0];
        //private static IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
        private static Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static ips Client_IP
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                string[] ClientIP_list = new string[host.AddressList.Length];

                for (int i = 0; i < host.AddressList.Length; i++)
                {
                    if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        ClientIP_list[i] = host.AddressList[i].ToString();
                    }
                }

                ips result = new ips(host.AddressList.Length, ClientIP_list);
                
                return result;
            }
        }
        public static bool set_socket(string port)
        {

            return false;
        }

        public static bool file_transfer(string address, string filename)
        {
            
            
            return false;
        }
    }

    class ips
    {
        private int many;
        private string[] ip_list;

        public ips(int m, string[] list)
        {
            many = m;
            ip_list = list;
        }

        public int get_many
        {
            get { return many; }
        }

        public string[] get_ip_list
        {
            get { return ip_list; }
        }

    }
}
