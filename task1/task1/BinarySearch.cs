using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    
    /// <summary>
    /// Binary search operations: get,add,remove
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// creating a node item for the basic building of a binary tree that is consisting two child:- left and right node
        /// </summary>
        private class Binarynode
        {
            public int item;
            public Binarynode right;
            public Binarynode left;

            /// <summary>
            ///  Constructor to create a single node item as like root
            /// </summary>
            /// <param name="item">passing item parameters</param>
            public Binarynode(int item)
            {
                this.item = item;
                left = null;
                right = null;

            }
        }
        /// <summary>
        /// 1.array of values
        /// 2.Points to the root of the tree
        /// 3.count  will return total number of nodes in the tree.
        /// 4.generic compare Interface to compare two int value 
        /// & .defualt returns default sort order comparer for the type specified by the generic argument. 
        /// </summary>
        private int[] data; 
        private Binarynode _root;
        private int _count;
        private IComparer<int> _comparer = Comparer<int>.Default;
        /// <summary>
        /// create constructor for that 
        /// Initially root is equal to null & ofcourse count is also null 
        /// & allocate space for array
        /// then for loop for count the node one by one and sorted data.
        /// </summary>
        /// <param name="size"></param>
        public BinarySearch(int size)
        {
            _root = null;
            _count = 0;
            data = new int[size]; 
            for (int i = 0; i < size; i++)
            {
                data[i] = _count;
            }
            Array.Sort(data);
        }

        public bool BEmpty
        {
            get { return this._count == 0; }
        }
        /// <summary>
        /// Returns the number of nodes in the tree
        /// Number of nodes in the tree
        /// </summary>
        public int BCount
        {
            get { return this._count; }
        }
        
       /// <summary>
       /// Add method:
       /// if the root is null then create a new root and increase by one ans so on and if it is not return the add_sub method 
       /// </summary>
       /// <param name="Item">passing item to be current node</param>
       /// <returns>Sucessfull</returns>
        public bool Add(int Item)
        {
            if (_root == null)
            {
                _root = new Binarynode(Item);
                _count++;
                return true;
            }
            else
            {
                return Add_Sub(_root, Item);
            }
        }
        /// <summary>
        ///  Add a symbol to the tree if it's a new one. Returns reference to the new
        ///  node if a new node inserted, else returns null to indicate node already present.
        ///  1. Starting at the root of the tree, search the binary tree comparing the new key to the key in the current node. 
        ///  If the new key is less than the current node, search the left subtree. If the new key is greater than the current node, search the right subtree.
        ///  2. When there is no left (or right) child to search, we have found the position in the tree where the new node should be installed.
        ///  3. To add a node to the tree, create a new TreeNode object and insert the object at the point discovered in the previous step.
        /// </summary>
        /// <param name="Node">Name of node to add to tree</param>
        /// <param name="Item">Value of node</param>
        /// <returns> Returns reference to the new node is the node was inserted.
        /// Returns a default sort order comparer for the type specified by the generic argument.</returns>
        private bool Add_Sub(Binarynode Node, int Item)
        {
            if (_comparer.Compare(Node.item, Item) < 0)
            {
                if (Node.right == null)
                {
                    Node.right = new Binarynode(Item);
                    _count++;
                    return true;
                }
                else
                {
                    return Add_Sub(Node.right, Item);
                }
            }
            else if (_comparer.Compare(Node.item, Item) > 0)
            {
                if (Node.left == null)
                {
                    Node.left = new Binarynode(Item);
                    _count++;
                    return true;
                }
                else
                {
                    return Add_Sub(Node.left, Item);
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Throwing this in to help test the tree
        /// </summary>
        public void Print()
        {
            Print(_root, 4);
        }

        private void Print(Binarynode p, int padding)
        {
            if (p != null)
            {
                if (p.right != null)
                {
                    Print(p.right, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.right != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.item.ToString() + "\n ");
                if (p.left != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.left, padding + 4);
                }
            }
        }
        /// <summary>
        /// Find the next ordinal node starting at node startNode.
        /// Due to the structure of a binary search tree, the
        /// successor node is simply the left most node on the right branch.
        /// </summary>
        /// <param name="value">Name key to use for searching</param>
        /// <returns>Returns a reference to the node if successful, else null</returns>
        public int Search(int value)
        {
            int found = -1;
            Binarynode localRoot = _root;
            found = find(value, "left", localRoot);
            if (found == -1)
            {
                localRoot = _root;
                found = find(value, "right", localRoot);
            }
            if (found == -1)
            {
                Console.WriteLine("Item {0} not found in tree.", value);
            }
            return found;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="findSide"></param>
        /// <param name="localRoot"></param>
        /// <returns></returns>
        private int find(int value, string findSide, Binarynode localRoot)
        {
            int found = -1;
            //Binarynode localRoot = _root;
            while (localRoot != null)
            {
                if (value.Equals(localRoot.item))
                {
                    found = localRoot.item;
                    break;
                }
                else if (localRoot.left != null && value.Equals(localRoot.left.item))
                {
                    found = localRoot.left.item;
                    break;
                }
                else if (localRoot.right != null && value.Equals(localRoot.right.item))
                {
                    found = localRoot.right.item;
                    break;
                }
                if (findSide.Equals("left"))
                {
                    localRoot = localRoot.left;
                }
                else if (findSide.Equals("right"))
                {
                    localRoot = localRoot.right;
                }
            }

            if (found != -1)
            {
                Console.WriteLine("Item found in tree = {0} on side = {1}", found, findSide);
                return found;
            }
            return found;
        }

      /*  /// <summary>
        /// Delete a given node. This is the more complex method in the binary search
        /// class. The method considers three senarios, 1) the deleted node has no
        /// children; 2) the deleted node as one child; 3) the deleted node has two
        /// children. Case one and two are relatively simple to handle, the only
        /// unusual considerations are when the node is the root node. Case 3) is
        /// much more complicated. It requires the location of the successor node.
        /// The node to be deleted is then replaced by the sucessor node and the
        /// successor node itself deleted. Throws an exception if the method fails
        /// to locate the node for deletion.
        /// </summary>
        /// <param name="key">Name key of node to delete</param>
        public int delete(string key)
        {
            int deletenode=-1;
            Console.WriteLine("Deleting node= {0}", key);
            Binarynode localRoot = null;
            // First find the node to delete and its parent
            Binarynode nodetodelete = find(key, localRoot, value);
            if (nodetodelete == null)
                throw new Exception("Unable to delete node: " + key);  // can't find node, then say so 
            // Three cases to consider, leaf, one child, two children

            // If it is a simple leaf then just null what the parent is pointing to
            if ((nodetodelete.left == null) && (nodetodelete.right == null))
                {
                    if (localRoot == null)
                    {
                        _root = null;
                        
                    }
                 // One of the children is null, in this case
                // delete the node and move child up
                if (nodetodelete.left == null)
                {
                    // Special case if we're at the root
                    if (localRoot == null)
                    {
                        _root = nodetodelete.right;
                        
                    }
            // Identify the child and point the parent at the child
                    if (localRoot.left == nodetodelete)
                        localRoot.right = nodetodelete.right;
                    else
                        localRoot.left = nodetodelete.right;
                    nodetodelete = null; // Clean up the deleted node
                    _count--;
                    
                // One of the children is null, in this case
                // delete the node and move child up
                if (nodetodelete.right == null)
                {
                    // Special case if we're at the root			
                    if ( localRoot == null)
                    {
                         _root= nodetodelete.left;
                       
                    }

                    // Identify the child and point the parent at the child
                    if (localRoot.left == nodetodelete)
                        localRoot.left = nodetodelete.left;
                    else
                        localRoot.right = nodetodelete.left;
                    nodetodelete = null; // Clean up the deleted node
                    _count--;
                   // Both children have nodes, therefore find the successor, 
                // replace deleted node with successor and remove successor
                // The parent argument becomes the parent of the successor
                Binarynode successor = find(nodetodelete, localRoot);
                // Make a copy of the successor node
                Binarynode tmp = new Binarynode(successor.item, successor.left);
                // Find out which side the successor parent is pointing to the
                // successor and remove the successor
                if (localRoot.left == successor)
                    localRoot.left = null;
                else
                    localRoot.right = null;

                // Copy over the successor values to the deleted node position
                nodetodelete.item = tmp.item;

                _count--;
                

                return deletenode;
        }*/

    }
}

