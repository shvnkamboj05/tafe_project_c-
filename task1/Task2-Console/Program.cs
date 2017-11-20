using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Windows.Forms;


namespace Task2_Console
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // 
           // Utility.computeHashTableAddAndSearchTime(100);
            //Result res = new Result();
            //Utility.computeLinkedListAddAndSearchTime(10);
            Application.EnableVisualStyles();
            Application.Run(new Result());
            
            Console.ReadLine();
        }

    }
}
