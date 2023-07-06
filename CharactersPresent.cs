using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CharactersPresent
    {
        public void print()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            bool isAPresent = input.Contains('a');
            bool isEPresent = input.Contains('e');
            bool isPPresent = input.Contains('p');
            if (isAPresent && isEPresent && isPPresent)
            {
                Console.WriteLine("all are presnet");
            }
            else if (isAPresent || isEPresent || isPPresent)
            {
                Console.WriteLine("one r more presnt");
            }
            else
                Console.WriteLine("none presnet");
            Console.ReadLine();
        }
    }
}
