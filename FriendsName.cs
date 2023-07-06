using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class FriendsName
    {
        public void meth1()
        {
            string[] friends = new string[5];
            for(int i=0;i<5;i++)
            {
                friends[i] = Console.ReadLine();
            }
            foreach(string friend in friends)
            {
                Console.WriteLine(friend);
                Console.ReadLine();
            }
            
        }

    }
}