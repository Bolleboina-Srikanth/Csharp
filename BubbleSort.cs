using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class BubbleSort
    {
        public BubbleSort()
        {
            Console.WriteLine("enter size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter" + size + "elements");
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Before sort:");
            for(int i=0;i<size;i++)
            {
                Console.Write(arr[i]+",");
            }
            for(int i=0;i<size;i++)
            {
                for(int j=i+1;j<size;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nAfter bubble sort:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
