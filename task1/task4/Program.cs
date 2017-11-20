using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using System.Threading;

using System.Net.Sockets;

using System.Collections;
using System.Windows.Forms;


namespace task4
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            //Application.Run(new ClientNew());
            var task1 = Task.Factory.StartNew(() => { Application.Run(new ClientNew()); });
            
            Console.WriteLine("Starting server...");
            var task2 = Task.Factory.StartNew(() => { Server.startServer(); });
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Starting client...");
            Client.startClient();
            Console.ReadLine();

        }
      
    }
}
