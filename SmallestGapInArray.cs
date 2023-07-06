using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    using System;

    class SmallestGapInArray
    {
        public void smallestGap()
        {
            int[] number1 = { 2, 3, 9, 23, 5, 11 };
            Array.Sort(number1);
            int smallestGap = int.MaxValue;//1 5
            for(int i=1;i<number1.Length;i++)//1 2 3
            {
                int currentGap = number1[i] - number1[i - 1];
                if (currentGap < smallestGap)
                    smallestGap = currentGap;
               
            }
            Console.WriteLine(smallestGap);
            Console.ReadLine();
        }
    }
}

