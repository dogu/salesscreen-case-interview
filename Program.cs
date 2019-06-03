using System;

namespace SalesScreen.CaseInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(11);

            //Task 1 - Print the available funds (balance + credit) for the bank account
            bankAccount.FetchAccountInfo();
            var availableFunds = bankAccount.GetAvailableFunds();
            Console.WriteLine($"Available funds: {availableFunds}");

            //Task 2: Fetch the transactions for the last 30 days. Print the total sum of the transactions, and the average value of the transactions.
            //TODO: Add you code here

            //Task 3: Compare the monthly spend for the last 3 months against the monthly budget configured for the account.
            //        Print a list for each month, with the difference between the budget and actual expenses for each category.
            //TODO: Add your code here
        }
    }
}
