using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class FloatArray
    {
        public void FloatArrays()
        {
            float[] numbers = { 2.6f, 1.6f, 8.3f, 3.9f, 4.9f };
           // int count = numbers.Length;
            float sum = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }
            float average = sum / numbers.Length;
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
