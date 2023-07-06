using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ShiftZeroToRight
    {
       // public object Arrays { get; private set; }

        public  ShiftZeroToRight()
        {
            int[] arr = {2,3,0,1,0,2,0};
            int index = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]!=0)
                {
                    arr[index] = arr[i];
                    index++;
                }
            }
            while(index<arr.Length)
            {
                arr[index] = 0;
                index++;
            }
            Console.Write(string.Join(", ",arr));
            Console.ReadKey();
        }
    }
}
