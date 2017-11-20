using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
       public struct keyPair<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

       public class HashTableImpl<K, V>
       {
           private readonly int size;
           private readonly LinkedList<keyPair<K, V>>[] items;

           public HashTableImpl(int size)
           {
               this.size = size;
               items = new LinkedList<keyPair<K, V>>[size];
           }

           protected int GetArrayPosition(K key)
           {
               int position = key.GetHashCode() % size;
               return Math.Abs(position);
           }

           public void Add(K key, V value)
           {
               int position = GetArrayPosition(key);
               LinkedList<keyPair<K, V>> linkedList = GetLinkedList(position);
               keyPair<K, V> item = new keyPair<K, V>() { Key = key, Value = value };
               linkedList.AddLast(item);
           }

           public void Remove(K key)
           {
               int position = GetArrayPosition(key);
               LinkedList<keyPair<K, V>> linkedList = GetLinkedList(position);
               bool itemFound = false;
               keyPair<K, V> foundItem = default(keyPair<K, V>);
               foreach (keyPair<K, V> item in linkedList)
               {
                   if (item.Key.Equals(key))
                   {
                       itemFound = true;
                       foundItem = item;
                   }
               }

               if (itemFound)
               {
                   linkedList.Remove(foundItem);
               }
           }

           public V Search(K key)
           {
               int position = GetArrayPosition(key);
               LinkedList<keyPair<K, V>> linkedList = GetLinkedList(position);
               foreach (keyPair<K, V> item in linkedList)
               {
                   if (item.Key.Equals(key))
                   {
                       return item.Value;
                   }
               }

               return default(V);
           }

           protected LinkedList<keyPair<K, V>> GetLinkedList(int position)
           {
               LinkedList<keyPair<K, V>> linkedList = items[position];
               if (linkedList == null)
               {
                   linkedList = new LinkedList<keyPair<K, V>>();
                   items[position] = linkedList;
               }

               return linkedList;
           }
          
       }


    }
