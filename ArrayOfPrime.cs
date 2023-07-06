using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ArrayOfPrime
    {
        public void primeNumbers()
        {
            int[] numbers = { 3, 7, 18, 8, 12, 11, 17 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 1; j <= numbers[i]; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        count++;
                    }
                }
                if (count <= 2 && count != 0)
                {
                    Console.Write(numbers[i]+" ");
                }
                
            }
            Console.ReadLine();
        }
    }
}