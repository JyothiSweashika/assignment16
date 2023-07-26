using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter account holder's name: ");
            string accountHolderName = Console.ReadLine();

            Bankaccount account = new Bankaccount(accountHolderName);

            Console.Write("Enter amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            try
            {
                account.Deposit(depositAmount);
                Console.WriteLine("Account Holder: " + account.AccountHolderName);
                Console.WriteLine("Account Number: " + account.AccountNumber);
                Console.WriteLine("Balance after deposit: $" + account.GetBalance());

                Console.Write("Enter amount to withdraw: ");
                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());


                try
                {
                    account.Withdraw(withdrawalAmount);
                    Console.WriteLine("Balance after withdrawal: $" + account.GetBalance());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
