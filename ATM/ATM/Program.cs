﻿using System;
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
                switch (Console.ReadLine())
                {
                    case "1":
                        ViewBalance(balance);
                        break;
                    case "2":
                        Console.WriteLine("How much would you like to deposit?");
                        Console.Write("Amount: ");
                        string deposit = Console.ReadLine();
                        balance = AddToBalance(balance, Convert.ToDouble(deposit));
                        break;
                    case "3":
                        Console.WriteLine("How much would you like to withdraw?");
                        Console.Write("Amount: ");
                        string withdrawal = Console.ReadLine();
                        WithdrawFromBalance(balance, Convert.ToDouble(withdrawal));
                        break;
                    case "4":
                        Console.WriteLine("Thanks for banking with Shitake Bank!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
            }
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