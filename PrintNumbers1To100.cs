using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class PrintNumbers1To100
    {
        public PrintNumbers1To100()
        {
            Console.WriteLine("print numbers 1 to 100");
            int num = 1;
            while(num<=100)
            {
                Console.Write(num+" ");
                num += 1;
            }
           // Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
