using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DateTime
    {
        
        public void meth7()
        {
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the month [1-12]:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the date [1-31]");
            int date = int.Parse(Console.ReadLine());
           // DateTime cuurentDate = new DateTime(year, month, date);
           // DateTime nextDate = currentDate.AddDays(1);
            //Console.WriteLine(nextDate.ToString("yyyy-mm-d"));
        }
    }
}
