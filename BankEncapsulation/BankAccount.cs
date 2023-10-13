using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private decimal balance = 0.00m;

        public static void MainMenu(BankAccount account, bool exit)
        {
            while (exit == true)
            {
                Console.WriteLine(@"______             _    _                ___              ");
                Console.WriteLine(@"| ___ \           | |  (_)              / _ \ ");
                Console.WriteLine(@"| |_/ / __ _ _ __ | | ___ _ __   __ _  / /_\ \_ __  _ __ ");
                Console.WriteLine(@"| ___ \/ _` | '_ \| |/ / | '_ \ / _` | |  _  | '_ \| '_ \");
                Console.WriteLine(@"| |_/ / (_| | | | |   <| | | | | (_| | | | | | |_) | |_) |");
                Console.WriteLine(@"\____/ \__,_|_| |_|_|\_\_|_| |_|\__, | \_| |_/ .__/| .__/ ");
                Console.WriteLine(@"                                 __/ |       | |   | |  ");
                Console.WriteLine(@"                                |___/        |_|   |_|    ");
                Console.WriteLine(@"---------------------------------------------------------");
                Console.WriteLine("");

                bool isNumber;
                int menuOption;


                do
                {

                    Console.WriteLine("What brings you in today");
                    Console.WriteLine(@"1) Deposit");
                    Console.WriteLine(@"2) Check Balance");
                    Console.WriteLine(@"3) Exit");
                    Console.WriteLine(@"-----------------------");
                    Console.Write("Selection:");

                    isNumber = int.TryParse(Console.ReadLine(), out menuOption);

                } while (!isNumber);

                switch (menuOption)
                {
                    case 1:
                        account.DepositAmount();
                        break;
                    case 2:
                        account.GetBalance();
                        break;
                    default:
                        Console.WriteLine("Goodbye!");

                        exit = false;
                        break;
                }
            }
        }

        public void DepositAmount()
        {
            decimal dollarAmount;
            bool isDollar;

            do
            {
                Console.WriteLine("How much would you like to deposit?");

                isDollar = (decimal.TryParse(Console.ReadLine(), out dollarAmount));

            } while (!isDollar);

            Deposit(dollarAmount);
            Console.WriteLine($"Deposited {dollarAmount} into your account.");          
            
            
        }

        void Deposit(decimal depositAmount)
        {
            balance += depositAmount;
        }

        decimal GetBalance()
        {
            Console.WriteLine($"{balance}");

            return balance;
        }

         
    }
}




        
    

