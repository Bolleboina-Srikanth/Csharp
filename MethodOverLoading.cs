using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class MethodOverLoading
    {
        void meth1()
        {
            Console.WriteLine("meth1 called");
        }
        void meth1(string s)
        {
            Console.WriteLine(s);
        }
      /*  public static void Main()
        {
            MethodOverLoading m = new MethodOverLoading();
            m.meth1();
            m.meth1("overloading");
        }*/
    }
}
