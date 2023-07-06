using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SecondLargestElement
    {
        public void secondLargestElement()
        {
            Console.WriteLine("enter size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("input" + size + "elements");
            for(int i=0;i<size;i++)
            {
                Console.Write("element-{0}:", i);
                array[i] = int.Parse(Console.ReadLine());
                
            }
            int largestNum = 0;//5,9
            int secondLargest = 0;//0 5
            for(int i=0;i<array.Length;i++)//5,9,2,6
            {
                if (array[i]>largestNum)//
                {
                    secondLargest = largestNum;
                    largestNum = array[i];
                }
                else if (array[i]>secondLargest && array[i]!=largestNum)
                {
                    secondLargest = array[i];
                }
                
            }
            Console.WriteLine(secondLargest);
            Console.ReadLine();
        }
    }
}
