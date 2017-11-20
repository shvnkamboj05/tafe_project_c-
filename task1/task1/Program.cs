using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //linked list
            Linkedlist list = new Linkedlist();
            Console.WriteLine("Linked List: ADD, Remove, Search and Sort");
            Console.WriteLine("Is it empty:-" + list.Empty + "\n");
            Console.WriteLine("Linked List:-");
            list.Add(0, "c language");
            list.Add(1, "c++");
            list.Add(2, "Java");
            list.Add(3, "C#");
            list.Add(4, "Visual basic");
            list.Add(5, "Php");
            list.Add(6, "Anroid");
            list.Add(7, "CMS");
            list.Add(8, "HTML");
            list.Add(9, "Javascript");
            list.Add(10, "CSS");
            Console.WriteLine("Count the item in the linked list:-" + list.Count);
            list.printAllNodes();
            list.remove("Anroid");
            // This red node will not be found.
            list.Search("Anroid");
            // Blue Node will be found
            list.Search("C#");
            Console.WriteLine("\nRemaining nodes available in the list...");
            list.printAllNodes();
            
            // list.clear();

            Console.WriteLine("\n");

            //BinarySearch
            Console.WriteLine("Binary Tree: ADD, Remove and Search\n");
            BinarySearch bS = new BinarySearch(2);
            Console.WriteLine("Is it empty:-" + bS.BEmpty + "\n");
            Console.WriteLine("Binary Tree:-");
            bS.Add(6);
            bS.Add(2);
            bS.Add(3);
            bS.Add(11);
            bS.Add(30);
            bS.Add(9);
            bS.Add(13);
            bS.Add(18);
            bS.Print();
            Console.WriteLine("\nCount the node in the BinaryTree:-" + bS.BCount);
            Console.WriteLine("search element:-");
            bS.Search(2);
            bS.Search(1);
            bS.Search(9);
           
            //bS.binarysearch(2);

            // Create a new binary tree
            /*BinaryTreeNew bt = new BinaryTreeNew();

            // Insert data
            bt.insert ("Shivani Kamboj", 1);
            bt.insert ("Shanaya Kamboj", 2);
            bt.insert ("Alex Perry ", 3);
 
            // Retrieve data  
            string search = "Shivani Kamboj";
            TTreeNode entry = bt.searchTree (search);
            if (entry != null)
            {
                Console.WriteLine("Found entry for {0} with integer code = {1}", entry.name, entry.value);
            }
            else
            {
                Console.WriteLine("No entry found for - " + search);
            }
               
            Console.WriteLine("Total Entries Found -- " + bt.count());
            bt.delete("Shivani Kamboj");

            TTreeNode entry1 = bt.searchTree(search);
            if (entry1 != null)
            {
                Console.WriteLine("Found entry for {0} with integer code = {1}", entry1.name, entry1.value);
            }
            else
            {
                Console.WriteLine("No entry found for - " + search);
            }
            Console.WriteLine("Total Entries Found -- " + bt.count());
            */

            //HashTable
            Console.WriteLine("\n");
            Console.WriteLine("HashTable: ADD, Remove and Search\n");

            HashTableImpl<string, string> hash = new HashTableImpl<string, string>(20);

            hash.Add("1", "item 1");
            hash.Add("2", "item 2");
            hash.Add("name", "shivani");
           

            string one = hash.Search("1");
            Console.WriteLine("Value for 1st Key - " + one);
            string two = hash.Search("2");
            Console.WriteLine("Value for 2nd Key - " + two);
            string name = hash.Search("name");
            Console.WriteLine("Value for 3rd Key - " + name);
            Console.WriteLine("Removing value for Key - " + "1");
            hash.Remove("1");
            



            Console.ReadLine();
            //BinarySearch
            //int searchInt; // seach key
            //int position; // location of search key in array

            //// create array and output it
            //BinarySearch searchArray = new BinarySearch(15);
            //Console.WriteLine(searchArray);

            //// prompt and input first int from user
            //Console.Write("Please enter an integer value (-1 to quit): ");
            //searchInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //// repeatedly input an integer; -1 terminates the application
            //while (searchInt != -1)
            //{
            //    // use binary search to try to find integer
            //    position = searchArray.Binaryget(searchInt);

            //    // return value of -1 indicates integer was not found
            //    if (position == -1)
            //        Console.WriteLine("The integer {0} was not found.\n", searchInt);
            //    else
            //        Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

            //    // Prompt and input next int from user 
            //    Console.WriteLine("Please enter an integer value (-1 to quit): ");
            //    searchInt = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();

            //}

        }

    }
}
