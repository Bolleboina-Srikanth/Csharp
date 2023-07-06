using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PrintNumber10Times
    {
        public void print()
        {
            Console.WriteLine("Enter any number");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int number))
            {


                int result = (number * 10);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}