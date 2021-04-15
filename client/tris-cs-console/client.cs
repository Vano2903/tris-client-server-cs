using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace tris_cs_console
{
    class client
    {
        //attributi privati
        private Socket sender;
        
        //attributi pubblici

        //metodi privati

        //metodi pubblici
        public Tuple connect()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
  
                try
                {
                    sender.Connect(remoteEP);

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    return new Tuple(false, "error");
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                    return new Tuple(false, "error");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    return new Tuple(false, "error");
                }
                this.sender = sender;
                return new Tuple(true, "nil");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
