using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_HANDLING
{
    public class MinimumAccountBalance : Exception
    {
        String message;
        public MinimumAccountBalance(String message)
        {
            this.message = message;
        }
        public override string HelpLink 
        {
        get
            {
                return this.message;
            }
        }
    }
    public class UserDefinedException
    {
        static double current_balance = 1000;
        public static void Main()
        {
            Console.WriteLine("enter amount to withdraw");
            int amount = int.Parse(Console.ReadLine());
            try
            {
                if(current_balance<amount)
                {
                    throw new MinimumAccountBalance("Insufficient funds! your current balance is " + current_balance);
                }
                else if(amount<0)
                {
                    throw new MinimumAccountBalance("please enter a valid amount");
                }
                else
                {
                    Console.WriteLine("please take the money " + amount);
                    Console.ReadLine();
                }
            }
            catch(MinimumAccountBalance e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);
               // Console.WriteLine(e.Source);
               // Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
