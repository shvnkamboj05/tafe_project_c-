using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;


    public class Client
    {

        static string message = null;
        static TcpClient tcpclnt = null;


        public static void startClient()
        {
            try
            {
                string client = "CLIENT:: ";
                tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect("127.0.0.1", 8001); // use the ipaddress as in the server program
                Console.WriteLine(client + "Client is Connected to server...");
                while (true)
                {
                    //String str = Console.ReadLine();
                    if (getMessage() == null)
                    {
                        continue;
                    }
                    String str = getMessage();
                    Stream stream = tcpclnt.GetStream();

                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(str);

                    stream.Write(ba, 0, ba.Length);
                    System.Threading.Thread.Sleep(500);

                    Byte[] data = new Byte[256];

                    String responseData = String.Empty;

                    // Read the first batch of the TcpServer response bytes.
                    Int32 bytes = stream.Read(data, 0, data.Length); //(**This receives the data using the byte method**)
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes); 

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
            finally
            {
                tcpclnt.Close();
            }
        }

        public static void sendMessage(String msg)
        {
            message = msg;
            //Server.sendMessage(msg);
        }

        public static string getMessage()
        {
            return message;
        }
    }