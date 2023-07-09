using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    internal class Encapsulation
    {
        /* private string name;
         private string rollno;
        private string branch;
        public void SetName(string name)
         {
             this.name = name;
         }
         public  string GetName()
         {
             return this.name;
         }
         public void SetRollno(string rollno)
         {
             this.rollno = rollno;
         }
         public string GetRollno()
         {
             return this.name;
         }
         public void SetBranch(string branch)
         {
             this.branch = branch;
         }
         public string GetBranch()
         {
             return this.branch;
         }*/
        private int Amount;
        public void SetAmount(int Amount)
        {
            if(Amount>0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("enter positive number");
            }
        }
        public int GetAmount()
        {
            return this.Amount;
        }
    }
}