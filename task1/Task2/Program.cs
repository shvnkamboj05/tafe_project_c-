using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 200;
            task1.HashTableImpl<string, string> hastable = new task1.HashTableImpl<string, string>(input);
            for (int i = 0; i < input; i++ )
            {
                string random = RandomString(5);
                hastable.Add(random + "-Key", random + "-Value");
            }
                 
        }

        private static string RandomString(int size)
        {
            return Guid.NewGuid().ToString("n");
        }
    }
}
