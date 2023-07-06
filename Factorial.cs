using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Factorial
    {
        public  Factorial()
        {
            Console.WriteLine("Enter any number");
            int number =int.Parse( Console.ReadLine());
            long fact = 1;
            for(int i=1;i<=number;i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + number + " is " + fact);
            Console.ReadLine();

        }
    }
}
