using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    
   
    /// <summary>
    ///  Linked List – Add, Remove, Get, Sort
    ///  add(object),add(int position,object),remove,search, sort
    /// </summary>
    public class Linkedlist
    {
     /// <summary>
        ///  Linked list class as follows: Node 'headnode' is the first node and 'Count' will return total number of nodes in linked list.
     /// </summary>
        private Node headnode;
        private int count;
        // public class CollectionEventArgs : EventArgs
        //   {
        //public CollectionEventArgs():base(){}
        //    }

        /// <summary>
        ///  intially ,headnode value will be null and count value will be empty so we will create constructor for that setting.
        /// </summary>
        public Linkedlist()
        {
            this.headnode = null;
            this.count = 0;
        }

        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        /// <summary>
        /// Add method: this method will add node at start, middle, last node and somewhere else in the list and it will increase count by one.
        /// if index is greater then zero then it will throw the exception index value out of range.
        /// if index is less than count.... index is equal to count & we will take current node ('current' will have latest node) becomes head node in the list.
        /// (for example d=> d is new node added in to beginning for reference (this.headnode) a=>b=>c)
        /// if (this.Empty || index == 0):-if we are adding somewhere else in the list so that we will take if-else-statement and if list is empty or index is zero
        /// which means that we wanna put node in the begining of the list and if node is empty the head will be null so it doesnot point  to the next one.
        /// then we will just make the else statement if it's not empty means node in the list and for the reference point to the headnode.. for that we're going to 
        /// do is just set the current node equal to current node dot next node which basically moves the node to the next one.
        /// current next equal to new node with the object data so o and current dot next as its next node(for example a goes to b to goes to D & we want to insert at nd element
        /// what thsi is going to do if we are going to insert it right there the for loop the current one is curently selected as the node headnode so on)
        /// then all we need to increment the count so we know how many new objects are in there & then we do in return object that we inserted & add method is complete 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index:" + index);
            if (index > count)
                index = count;
            Node current = this.headnode;
            if (this.Empty || index == 0)
            {
                // this.headnode the reason why thi.headnode remember  the constructor for a new node takes the next node in the list.
                this.headnode = new Node(o, this.headnode);
            }
            else
            {
                //index start from 0 ..... a=>b=>add here c=>d 
                //for (int i = 0; i < index; i++)
                //{
                //current = current.Next;
                current = new Node(o, current);
                this.headnode = current;
                //}
            }
            count++;
            //index++;
            return o;
        }
        /// <summary>
        ///  this method will use for the implemetation of the above add method 
        ///  this mehod is the public object add it just takes the object now .... we were going to add this to the end of the list.
        ///  all we need to do here is return this add & for the overload the index we are going to add it to count
        ///  because that is one more than the list so it will put it in that poistion
        ///  as a new one at the end
        /// </summary>
        /// <param name="o">we pass it the object o</param>
        /// <returns></returns>
        public object Add(object o)
        {
            return this.Add(count, o);
        }
        /// <summary>
        ///Throwing this in to help test the list
        /// </summary>
        public void printAllNodes()
        {
            Node current = headnode;
            //Console.WriteLine(current.Data);
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        /// <summary>
        /// Delete a Node in the specified position
        /// </summary>
        /// <param name="key">key of node to be deleted</param>
        /// <returns>return integer value -1</returns>
        public object remove(string key)
        {
            if (key == null)
                throw new ArgumentOutOfRangeException("key: " + key);

            if (this.Empty)
                return null;

            int index = 0;
            Node previousNode = null;
            Node current = headnode;
            Console.WriteLine("\nRemoval in progess...");
            while (current != null)
            {
                if (string.Equals(current.Data, key) == true)
                {
                    //previousNode = current;
                    Console.WriteLine(string.Format("Item - {0} - found at index = {1}. Removing now... ", key, index));
                    if (current.Next == null)
                    {
                        previousNode.Next = null;
                    }
                    else
                    {
                        previousNode.Next = null;
                        previousNode.Next = current.Next;
                    }
                    return index;
                }
                previousNode = current;
                current = current.Next;
                index++;
            }
            Console.WriteLine(string.Format("Item - {0} - not found in list...", key));
            return -1;

         }
        /// <summary>
        /// Delete the all nodes from the list 
        /// </summary>
        public void clear()
        {
            this.headnode = null;
            this.count = 0;
        }

    /// <summary>
    /// search the node in the specified position
    /// </summary>
    /// <param name="key">key node is to be search from the list</param>
    /// <returns>return integer value -1</returns>
        public int Search(string key)
        {
            int index = 0;
            Node current = headnode;

            while (current != null)
            {
                if (string.Equals(current.Data, key) == true)
                {

                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1;

            /*if (index < 0)
                throw new ArgumentOutOfRangeException("index:" + index);

            if (this.Empty)
                return null;

            if (index > this.count)
                index = this.count - 1;

            Node current = this.headnode;


            for (int i = 0; i < index - 1; i++)

                current = current.Next;
            return current.Data;*/
        }
        

        /*  public bool Sort()
          {
             if (this.headnode.Value is IComparable)
              {
                 // check index out of range
                 if (this.headnode.Next == null)
                      return true;

                  if (headnode==null)
                  return true;

                  // get the base comparison
                  Node baseNode = this.headnode.Next;
                  for (int x = 2; x <= this.count; ++x)
                  {
                      if ((baseNode.previousNode.Value as
                        IComparable).CompareTo(
                          baseNode.Value) == 1)
                      {
                          Node comp = this.headnode;
                          bool found = false;
                          for (int y = 1; y < x && found != true; ++y)
                          {
                              if ((baseNode.Value as
                                   IComparable).CompareTo(comp.Value) != 1)
                              {
                                  // We need to change the references
                                  // to all of the nodes to re-order them.
                                  if (baseNode.HasNext)
                                  {
                                      baseNode.Next. previousNode =
                                         baseNode. previousNode;
                                      baseNode. previousNode.Next =
                                         baseNode.Next;
                                  }
                              }
                          }
                      }
                  }
               
          }
      }*/
    }
}

    

