using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Circle
    {
        public void meth7()
        {
            Console.WriteLine("enter diameter of circle");
            double diameter = double.Parse(Console.ReadLine());
            double radius = diameter / 2;
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("area:"+area);
            Console.WriteLine("perimeter:" + perimeter);
            Console.ReadLine();

        }
    }
}
