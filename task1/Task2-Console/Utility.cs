using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace Task2_Console
{
    class Utility
    {
        //private static Stopwatch stopwatch = new Stopwatch();

        public static string getRandomString(int length)
        {
          
            return Guid.NewGuid().ToString("n");
        }

        public static int getRandomInt()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            return Int32.Parse(r);
        }

        public static ArrayList getRandomStringList(int lenght)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < lenght; i++ )
            {
                arrayList.Add(getRandomString(5));
            }
            return arrayList;
        }

        public static List<int> getRandomIntList(int lenght)
        {
            List<int> arrayList = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < lenght; i++)
            {
                int k = Int32.Parse(generator.Next(0, 1000000).ToString("D6"));
                arrayList.Add(k);
            }
            return arrayList;
        }

        public static double computeHashTableAddAndSearchTime(int input)
        {
            Stopwatch stopwatch = new Stopwatch();
            // Hash Table performance Tests
            task1.HashTableImpl<string, string> hastable = new task1.HashTableImpl<string, string>(input);
            // Begin timing.
            ArrayList list = Utility.getRandomStringList(input);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Adding value to hashtable - " + list[i]);
                //string random = RandomString(5);
                hastable.Add(list[i] + "-Key", list[i] + "-Value");

            }
            Console.WriteLine("Time takeen to Add {0} items. Time elapsed: {1:hh\\:mm\\:ss}", input, stopwatch.Elapsed);

            // Get time for GET function 
            stopwatch.Start();
            for (int i = 0; i < list.Count; i++)
            {
                string key = list[i] + "-Key";
                // Console.WriteLine("Query value from hashtable - " + list[i]);
                //string random = RandomString(5);
                string value = hastable.Search(key);
                Console.WriteLine("Value found for key = {0}  Value = {1}", key, value);

            }
            //System.Threading.Thread.Sleep(1000);
            // Stop timing.
            stopwatch.Stop();
            double timeInMillis = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time takeen to GET {0} items. Time elapsed: {1} ms", list.Count, timeInMillis);
            return timeInMillis;
        }

        public static double computeLinkedListAddAndSearchTime(int input){
            Stopwatch stopwatch = new Stopwatch();
            task1.Linkedlist Linklist = new task1.Linkedlist();

            ArrayList list = Utility.getRandomStringList(input);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Adding value to linkedlist - " + list[i]);
               Linklist.Add(list[i]);
            }
            
            stopwatch.Start();
            for (int i = 0; i < list.Count; i++)
            {
                string key = list[i]+ "";
               
                int value = Linklist.Search(key);
                Console.WriteLine("Value found for key = {0}  Value = {1}", key, value);

            }
            //System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            double timeInMillis = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time takeen to GET {0} items. Time elapsed: {1} ms", list.Count, timeInMillis);
            return timeInMillis;
          }

         public static double computeBinaryTreeAddAndSearchTime(int input){
             Stopwatch stopwatch = new Stopwatch();
             task1.BinarySearch Linklist = new task1.BinarySearch(input);

             List<int> list = Utility.getRandomIntList(input);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Adding value to Binary Tree - " + list[i]);
                Linklist.Add(list[i]);
            }
            stopwatch.Start();
            for (int i = 0; i < list.Count; i++)
            {
                int key = list[i];

                int value = Linklist.Search(key);
                Console.WriteLine("Value found for key = {0}  Value = {1}", key, value);

            }
            //System.Threading.Thread.Sleep(1000);
            stopwatch.Stop();
            double timeInMillis = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("Time takeen to GET {0} items. Time elapsed: {1} ms", list.Count, timeInMillis);
            return timeInMillis;
          }
        }
    }


