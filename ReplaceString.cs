using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ReplaceString
    {
        public ReplaceString()
        {
            Console.WriteLine("enter your name");
            string userName = Console.ReadLine();
            if (userName.Length >= 3)
            {
                string message = "hello <<userName>>, how are you?";
                message = message.Replace("<<userName>>", message);
                Console.WriteLine(message);
            }
            else
                Console.WriteLine("user name have atleast 3 charcters");
            Console.ReadLine();
        }
    }
}
