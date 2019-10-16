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
            try
            {
            StartSequence();
            Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program has finished running.");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// Runs main sequence for ATM. Displays menu and picks options based on user input.
        /// </summary>
        private static void StartSequence()
        {
            double balance = 5000.00;
            bool atmOn = true;
            while (atmOn)
            {
                try
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
                        catch (Exception)
                        {
                                throw;
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
                        catch (Exception)
                        {
                                throw;
                        }
                    case "4":
                        Console.WriteLine("Thanks for banking with Shitake Bank!");
                            atmOn = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu option.");
                        break;
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
        /// <summary>
        /// Displays menu options in console.
        /// </summary>
        public static void DisplayMenu()
        {
            Console.WriteLine("\n\nWelcome to Shitake Bank!");
            Console.WriteLine("Options:");
            Console.WriteLine("1) View Balance");
            Console.WriteLine("2) Deposit");
            Console.WriteLine("3) Withdrawal");
            Console.WriteLine("4) Exit");
        }
        /// <summary>
        /// Takes in the current balance as a double and writes to the console the balance. Returns the balance.
        /// </summary>
        /// <param name="balance">Takes in current balance as a double.</param>
        /// <returns>Returns balance as a double.</returns>
        public static double ViewBalance(double balance)
        {
            Console.WriteLine($"Your current balance: ${balance}");
            return balance;
        }
        /// <summary>
        /// Takes in a balance and an amount to add. Adds amount to balance and returns a new balance.
        /// </summary>
        /// <param name="balance">Takes in current balance as a double.</param>
        /// <param name="addition">Takes in the amount to deposit as a double.</param>
        /// <returns>Returns the updated balance as a double.</returns>
        public static double AddToBalance(double balance, double addition)
        {
            if (addition > 0)
            {
            return addition + balance;
            }
            else
            {
                Console.WriteLine("Please enter a positive value. Returning to main menu.");
                return balance;
            }
        }
        /// <summary>
        /// Takes in a balance and an amount to withdraw. Subtracts the amount to withdraw from the balance and returns the new balance.
        /// </summary>
        /// <param name="balance">Takes in a balance as a double.</param>
        /// <param name="withdrawal">Takes in a withdrawal amount as a double.</param>
        /// <returns>Returns updated balance as a double.</returns>
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
