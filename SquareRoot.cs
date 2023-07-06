using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SquareRoot
    {
        public void squareRoot()
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            double temp;
            double sqroot = num / 2;
            do
            {
                temp = sqroot;
                sqroot = (temp + (num / temp)) / 2;
            }
            while ((temp - sqroot) != 0);
            {
                Console.WriteLine("square root of" + num + "is" + sqroot);
            }
            Console.ReadLine();
            }
    }
}
