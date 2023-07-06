using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo
{
    using System;
    using System.Security.Cryptography;

    public class Node
    {
        public int Key;
        public string Value;
        public Node Next;
        public Node(int key,string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
    public class HashTable
    {
       const int Size = 10; // Size of the hash table
         Node[] table;

        public HashTable()
        {
            table = new Node[Size];
        }

        private static int HashFunction(int key)
        {
            int result= key % Size;
            Console.Write(result+" ");
            Console.ReadLine();
            return result;// Simple hash function using modulo operator
        }

        public void Add(int key, string value)
        {
            int index = HashFunction(key);

            // Create a new node
            Node newNode = new Node( key,value );

            if (table[index] == null)
            {
                // If the bucket is empty, assign the new node to the bucket
                table[index] = newNode;
            }
            else
            {
                // If the bucket is not empty, add the new node at the beginning of the linked list
                newNode.Next = table[index];
               // Console.WriteLine(table[index]);
                table[index] = newNode;
            }
        }

        public void Get(int key)
        {
            int index = HashFunction(key);

            Node current = table[index];
         //   Console.WriteLine("current"+current.Key,current.Value);
         //   Console.ReadLine();
            // Traverse the linked list in the bucket to find the node with the specified key
            while (current != null)
            {
                if(current.Key!=key)
                {
                    Console.WriteLine("key value are not presnt");
                    Console.ReadLine();
                    return;
                }
                if (current.Key == key)
                {
                    Console.WriteLine(current.Key + " " + current.Value);
                    Console.ReadKey();
                   // return  current.Value; // Return the value if the key is found
                }
                current = current.Next;
            }

           // return null; // Return null if the key is not found
        }

        public void Display()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"[{i}]: ");
                Node current = table[i];
                while (current != null)
                {
                    Console.Write($"key:{current.Key}, value:{current.Value} ");
                   current = current.Next;
                }
                Console.ReadLine();
            }
        }
       

      /* public static void Main()
        {
           HasHTable hashtable = new HashTable();

            // Add key-value pairs to the hash table
            hashtable.Add(3, "John");
            hashtable.Add(8, "Jane");
            hashtable.Add(1, "Mike");
            hashtable.Add(9, "Sarah");
            hashtable.Add(12, "David");
            hashtable.Add(9, "Sri");
            hashtable.Add(9, "ram");

            // Display the hash table
           // hashtable.Display();

            // Get values for specific keys
              hashtable.Get(779);
            //  Console.WriteLine("\nValue for key 21: " + hashtable.Get(21));
           //  Console.WriteLine("\nValue for key 5: " + hashtable.Get(5));
           // bool r = hashtable.Contains(2);
        }*/
      
    }
}