using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class NumberString
    {
        public void meth3()
        {
            Console.WriteLine("Enter any number");
            string numberString=Console.ReadLine();
            if(int.TryParse(numberString, out int number))
            {
                string result = (number * 10).ToString();

                Console.WriteLine(result);
                
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
           Console.ReadLine();
        }
    }
}
