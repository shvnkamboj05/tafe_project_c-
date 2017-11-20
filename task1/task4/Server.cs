using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

public class Server {

    static TcpListener myList = null;
    static Socket socket = null;
    static string messgageFromClient = null;
    
    public static void startServer(){
        try {
            string server = "SERVER:: ";
		IPAddress ipAd = IPAddress.Parse("127.0.0.1"); 

        /* Initializes the Listener */
		myList=new TcpListener(ipAd,8001);

        /* Start Listeneting at the specified port */		
		myList.Start();
		
		Console.WriteLine(server + "The server is running at port 8001...");
        Console.WriteLine(server + "The local End point is  :" + myList.LocalEndpoint);
        Console.WriteLine(server + "Waiting for a connection.....");

        Console.WriteLine(server + "Server is ready to connect to Client. Now Accepting game options... ");
        socket = myList.AcceptSocket();
		while (true){
            byte[] b=new byte[500];
		    int k=socket.Receive(b);
            string fromClient = null;
            for (int i = 0; i < k; i++)
            {
                fromClient += Convert.ToChar(b[i]);
            }
            messgageFromClient = fromClient;
            Console.Write(server + "Recieved from client - " + fromClient);
            Console.WriteLine("\n" +server + "Sent Acknowledgement to client");
        }
	}
	catch (Exception e) {
		Console.WriteLine("Error..... " + e.StackTrace);
    }finally
        {
            /* clean up */
            socket.Close();
            myList.Stop();
        }
    }    
    public static string getMessage(){
        return messgageFromClient;
    }

    public static void setMessage(String msg)
    {
        messgageFromClient = msg;
    }

    public static void sendMessage(String msg)
    {
        socket.Send(Encoding.UTF8.GetBytes(msg));
        Client.sendMessage(msg);
    }
	
}