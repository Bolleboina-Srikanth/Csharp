using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DaysInToYears
    {
        public void days()
        {
            Console.WriteLine("Enter days");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int remainingDays = days % 365;
            int months = remainingDays / 30;
            int weeks = (remainingDays % 30)/7;
            Console.WriteLine("years:" + years);
            Console.WriteLine("months:" + months);
            Console.WriteLine("weeks:" + weeks);
            Console.ReadLine();
        }
    }
}
