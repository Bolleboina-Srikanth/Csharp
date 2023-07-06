using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class PlaceName
    {
        public void meth2()
        {
            Console.WriteLine("Enter place you like to visit");
            string placeName = Console.ReadLine();
            Console.WriteLine("placeName in uppercase:" + placeName.ToUpper());
            Console.WriteLine("placeName in uppercase:" + placeName.ToLower());
            Console.ReadKey();
        }
    }
}
