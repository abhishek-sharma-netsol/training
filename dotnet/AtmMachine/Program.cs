using System;
using Atm;

namespace AtmMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            int choice;
            while(true){
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Enter name, Account number, Account type");
                Console.WriteLine("2. Balance Enquiry");
                Console.WriteLine("3. Deposite Money");
                Console.WriteLine("4. Show Total balance");
                Console.WriteLine("5. Withdraw Money");
                Console.WriteLine("6. Cancel");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice){
                    case 1: {
                        b.SetValue();
                        break;
                    } 
                    case 2: {
                        b.ShowData();
                        break;
                    }
                    case 3: {
                        b.Deposit();
                        break;
                    }
                    case 4: {
                        b.ShowBalance();
                        break;
                    }
                    case 5: {
                        b.Withdrawl();
                        break;
                    }
                    case 6: {
                        Environment.Exit(0);
                        break;
                    }
                    default: {
                        Console.WriteLine("Invalid Choice");
                        break;
                    }
                }
            }
        }
    }
}
