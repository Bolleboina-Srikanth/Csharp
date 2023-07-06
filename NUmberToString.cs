using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class NUmberToString
    {
        public void String()
        {
            Console.WriteLine("enter any number");
            int number = int.Parse(Console.ReadLine());
            string result = "";
            if (number % 3 == 0)
                result += "Pling";
            if (number % 5 == 0)
                result += "Plang";
            if (number % 7 == 0)
                result += "Plong";
            if (result == "")
                result = number.ToString();
            Console.WriteLine(result+" ");
            Console.ReadLine();
        }
    }
}
