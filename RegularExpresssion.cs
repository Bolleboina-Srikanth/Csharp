using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTest1
{
    
    public class RegularExpression
    {
        
        public bool mobileNumber(string number)
        {
            Regex r = new Regex("^[6789][0-9]{9}");
            return r.IsMatch(number);
                 
        }
    }
}
