using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    /// <summary>
    /// creating a node for the basic building of a linked list that is consisting two properties:-
    /// one is data which will have data in the this node and other is the pointer to the next node.
    /// which will store the reference of the next node. So our node class will look like:
    /// </summary>
    class Node
    {
      private object data;
      private Node next;

      public Node(object data, Node next)
      {
          this.data = data;
          this.next = next;
      }
       
      public object Data
      {
          get { return this.data; }
          set { this.data = value; }
        
      }

    public Node Next
      {
          get { return this.next; }
          set { this.next = value; }
        
      }
    }
}
