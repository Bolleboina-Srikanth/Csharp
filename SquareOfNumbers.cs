using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class SquareOfNumbers
    {
        public void meth5()
        {
            Console.WriteLine("enter first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            double difference = num1 - num2;
            double squareOfSum = (Math.Pow(sum, 2));
            double squareOfDifferece = (Math.Pow(difference, 2));
            Console.WriteLine(squareOfSum);
            Console.Write(squareOfDifferece);
            Console.ReadLine();
        }
    }
}
