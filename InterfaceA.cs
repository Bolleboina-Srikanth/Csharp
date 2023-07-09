using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public interface InterfaceA:InterfaceB
    {
        void add(int a, int b);

    }
    public interface InterfaceB
    {
        void sub(int a, int b);

    }
    public class ChildClass : InterfaceA
    {
        public void add(int a,int b)
        {
        Console.WriteLine("sum:"+(a + b));
            Console.ReadKey();
    
        }
    public void sub(int a,int b)
    {
        Console.WriteLine("sub:"+(a - b));
            Console.ReadKey();
    }
       /* static void Main(string[] args)
        {
           ChildClass c= new ChildClass();
            c.add(1, 2);
           // c.sub(2, 1);
        }*/
    }
}