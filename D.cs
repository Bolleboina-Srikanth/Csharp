using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    internal class D
    {
       public static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "sri");
            d.Add(3, "sita");
            d.Add(2, "ram");
            Console.WriteLine(d.ContainsKey(2));
            foreach(KeyValuePair<int,string> element in d)
            {
                Console.WriteLine($"key:{element.Key}, Value:{element.Value}");
            }
            Console.ReadLine();
        }
    }
}
