using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class MethodOverRiding
    {
        public virtual void print()
        {
            Console.WriteLine("parent class method");
            Console.ReadLine();
        }
    }
    public class childClass:MethodOverRiding
    {
        public override void print()
        {
            Console.WriteLine("parent class method overriding");
            Console.ReadLine();
        }
       /* public static void Main()
        {
            MethodOverRiding m= new childClass();
            m.print();
        }*/
    }
}
