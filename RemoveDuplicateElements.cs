using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class RemoveDuplicateElements
    {
        public void removeElements()
        {
            object[] originalArray = { "Anna", "False", 25, System.DateTime.Now, 112.22, "Anna", "False" };
            Console.WriteLine("original Array:");
            for(int i=0;i<originalArray.Length;i++)
            {
                Console.WriteLine(originalArray[i]);
            }
            object[] newArray = originalArray.Distinct().ToArray();
            Console.WriteLine("\nNew array:");
            for(int i=0;i<newArray.Length;i++)
            {
                Console.WriteLine(newArray[i]);
            }
            Console.ReadLine();

        }
    }
}