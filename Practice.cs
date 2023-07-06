using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Practice
    {
        public void meth1()
        {
            int num1 = 2000;
            int num2 = 3200;
            bool istrue = true;
            for(int number=num1;number<=num2;number++)
            {
                if(number%7==0 && number%5!=0)
                {
                    if(istrue!=true)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(number);
                    istrue = false;
                }
            }
            Console.ReadLine();
        }
    }
}
