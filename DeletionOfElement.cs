using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DeletionOfElement
    {

        public void delete()
        {
            Console.WriteLine("eneter size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter position whre to delete");
            int position = int.Parse(Console.ReadLine());
            // if (position >= 0 && position <= size)
            {
                int[] newArray = new int[size - 1];
                int newArrayIndex = 0;
                for (int i = 0; i < array.Length; i++)
                {

                    if (i != position)
                    {
                        newArray[newArrayIndex] = array[i];
                        newArrayIndex++;
                    }
                }
                Console.WriteLine("the new list:");
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.Write(newArray[i] + " ");
                }
                // }
                // else
                //    Console.WriteLine("enter valid position");
                Console.ReadLine();
            }
        }
    }
}

