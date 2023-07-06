using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class NextDate
    {
        public void date()
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter month [1-12]");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter date [1-30]");
            int date = int.Parse(Console.ReadLine());
            //DateTime input = new DateTime(year, month, date);
            //Console.WriteLine(DateTime.Today.AddDays(1));

        }
    }
}
