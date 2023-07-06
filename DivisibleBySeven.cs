using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DivisibleBySeven
    {
        public DivisibleBySeven()
        {
            int start = 2000;
            int end = 3200;
            bool isTrue = true;
            for (int number = start; number <= end; number++)
            {
                if (number % 7 == 0 && number % 5 != 0)
                {
                    if (!isTrue)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(number);
                    isTrue = false;
                }
            }
           // Console.WriteLine();
            Console.ReadLine();
        }
    }
}