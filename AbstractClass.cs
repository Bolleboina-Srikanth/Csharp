using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public  abstract class Bank
    {
        public abstract void validateCard();
        public abstract void checkBalance();
        public abstract void withDrawbalance();
        public abstract void miniStatement();

    }
    public class Sbi :Bank
    {
        public override void validateCard()
        {
            Console.WriteLine("Validate your card ");
            Console.Read();
        }
        public override void checkBalance()
        {
            Console.WriteLine("check balancechrome");
            Console.Read();
        }
        public override void withDrawbalance()
        {
            Console.WriteLine("withdraw balance");
            Console.Read();
        }
        public override void miniStatement()
        {
            Console.WriteLine("mini statement");
            Console.Read();
        }
       // Console.Readline();
    }

        public class BankFactory
        {
          /*  public static void Main(string[] args)
            {
            Console.WriteLine("enetr bank name");
            string banktype = Console.ReadLine();
            if(banktype=="sbi")
            {
                 Bank b =new Sbi();
                b.validateCard();
                b.checkBalance();
                b.withDrawbalance();
                b.miniStatement();
            }
            }*/
        }
    }

