using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class QuadraticEquation
    {
        public QuadraticEquation()
        {
           // double root1, root2;
            Console.WriteLine("enter a value");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enter c value");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            if(discriminant>0)
            {
                Console.WriteLine("roots are real and different");
                double root1 = -b + Math.Sqrt(discriminant);
                double root2 = -b - Math.Sqrt(discriminant);
                Console.WriteLine("root1:" + root1);
                Console.WriteLine("root2:" + root2);

            }
            else if(discriminant==0)
            {

                Console.WriteLine("roots are real and equal");
                double root = -b / (2 * a);
               // double root2 = -b - Math.Sqrt(discriminant);
                Console.WriteLine("root:" + root);
               // Console.WriteLine("root2:" + root2);
            }
            else
            {
                Console.WriteLine("roots are distinct and imaginary");
            }
            Console.ReadLine();
        }
    }
}
