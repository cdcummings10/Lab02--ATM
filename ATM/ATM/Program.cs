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
            ViewBalance(balance);
        }

        public static double ViewBalance(double balance)
        {
            Console.WriteLine($"Your current balance: ${balance}");
            return balance;
        }

        public static double AddToBalance(double balance, double addition)
        {
            return balance;
        }
    }
}
