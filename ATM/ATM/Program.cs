using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
            Console.ReadLine();
        }

        private static void StartSequence()
        {
            double balance = 5000.00;
            bool atmOn = true;
            while (atmOn)
            {
                DisplayMenu();
                switch (Console.ReadLine())
                {
                    case "1":
                        ViewBalance(balance);
                        break;
                    case "2":
                        Console.WriteLine("How much would you like to deposit?");
                        Console.Write("Amount: ");
                        string deposit = Console.ReadLine();
                        try
                        {
                            balance = AddToBalance(balance, Convert.ToDouble(deposit));
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                            break;
                        }
                    case "3":
                        Console.WriteLine("How much would you like to withdraw?");
                        Console.Write("Amount: ");
                        string withdrawal = Console.ReadLine();
                        try
                        {
                            balance = WithdrawFromBalance(balance, Convert.ToDouble(withdrawal));
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                            break;
                        }
                    case "4":
                        Console.WriteLine("Thanks for banking with Shitake Bank!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu option.");
                        break;
                }
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\n\nWelcome to Shitake Bank!");
            Console.WriteLine("Options:");
            Console.WriteLine("1) View Balance");
            Console.WriteLine("2) Deposit");
            Console.WriteLine("3) Withdrawal");
            Console.WriteLine("4) Exit");
        }

        public static double ViewBalance(double balance)
        {
            Console.WriteLine($"Your current balance: ${balance}");
            return balance;
        }

        public static double AddToBalance(double balance, double addition)
        {
            return addition + balance;
        }
        public static double WithdrawFromBalance(double balance, double withdrawal)
        {
            if (withdrawal < balance)
            {
                return balance - withdrawal;
            }
            else
            {
                Console.WriteLine($"Sorry, current funds of ${balance} cannot support withdrawal of ${withdrawal}.");
                return balance;
            }
        }
    }
}
