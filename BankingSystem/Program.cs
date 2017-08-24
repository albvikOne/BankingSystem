using BankingSystem.BakingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<Account> bank = new Bank<Account>("Banca Transilvania");
            bool alive = true;
            while (alive)
            {
                Console.WriteLine("1.Open Account\n 2.Add Money\n 3.Withdraw Money\n");
                Console.WriteLine("4.Close Account\n 5.Loan Money\n 6.Account Information\n ");
                Console.WriteLine("7.Q&A\n 8.Close")
                    try
                {
                    int command = Convert.ToInt32(Console.ReadLine());
                    case 1:
                           OpenAccount(bank);
                           break;
                    case 2:
                           AddMoney(bank);
                           break;
                    case 3: 
                           WithDrawMoney(bank);
                           break;
                    case 4:
                           LoanMoney(bank);
                           break;
                    case 5:
                           AccountInformation(bank);
                           break;
                    case 6:
                           Questions(bank);
                           break;
                    case 7:
                           AccountInformation(bank);
                           break;
                    case 8:
                           CloseAccount(bank);
                           break;
                }bank.CalculateLoanPercentage();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
