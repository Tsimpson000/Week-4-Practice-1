using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Practice_1
{
    public static class BusinessInfo
    {
        public static string _businessName;
        public static double _taxAmount;

        static BusinessInfo()
        {
            _businessName = "Tylers Tilers";
            _taxAmount = .1;

        }
        public static void DisplayBusinessName()
        {
            Console.WriteLine(_businessName);
        }
    }
}
