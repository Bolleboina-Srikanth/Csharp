using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class RandomNumbers
    {
        public  void meth6()
        {
            Random random = new Random();
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(10, 51);
            }
           // Console.Write("generated numbers:"+string.Join(",",numbers));
           for(int i=0;i<5;i++)
            {
                Console.Write(numbers[i]+" ");
            }
            int sum = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
               // Console.Write("\n"+sum + " ");
            }
            double average = sum / 5;
            Console.WriteLine("\n"+(average));
            Console.ReadLine();
        }
    }
}

