using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    internal class PrimeNumbers
    {
        public void primeNumbers()
        {
            Console.WriteLine("print prime numbers between 1-100:");
            int startingNumber = int.Parse(Console.ReadLine());
            int endingNumber = int.Parse(Console.ReadLine());
            for(int number=startingNumber;number<=endingNumber;number++)
            {
                int count = 0;
                for(int i=1;i<=number;i++)
                {
                    if (number % i == 0)
                        count++;
                }
                if (count <= 2 && count != 0)
                    Console.Write(number+","+" ");
            }
            Console.ReadLine();
        }
        
    }
}
