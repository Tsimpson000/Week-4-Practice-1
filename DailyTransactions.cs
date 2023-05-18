using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Practice_1
{
    public static class DailyTransactions
    {
        public static List<Transaction> _transactions;


        static DailyTransactions()
        {
            _transactions = new List<Transaction>();
        }

        public static void AddTransaction(Transaction newTransaction)
        {
            _transactions.Add(newTransaction);
        }
        public static double CalculateTotal(double subTotal)
        {
            double total;
            
            total = (subTotal * BusinessInfo._taxAmount) + subTotal;
            return total;
        }
        public static void DisplayAllInfo()
        {
            Console.WriteLine(DailyTransactions._transactions);
        }

    }
}
