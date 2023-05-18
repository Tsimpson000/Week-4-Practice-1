namespace Week_4_Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessInfo.DisplayBusinessName();
            DailyTransactions.AddTransaction(new Transaction("Steak", 20));
            DailyTransactions.AddTransaction(new Transaction("Bell Pepper", 5));
            DailyTransactions.AddTransaction(new Transaction("Wine", 10));
            DailyTransactions.AddTransaction(new Transaction("Lobster", 25));
            DailyTransactions.AddTransaction(new Transaction("Butter", 5));

            DailyTransactions.DisplayAllInfo();
        }
    }
}