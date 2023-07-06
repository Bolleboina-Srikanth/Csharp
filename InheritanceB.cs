using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class InheritanceB : InheritanceA
    {
        public void meth1()
        {
            Console.WriteLine("a+b="+( a + b) );
            Console.ReadLine();
        }
        
    }
}
