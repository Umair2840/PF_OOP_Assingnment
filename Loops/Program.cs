using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int balance = 5000;
            int amount;
            int integerChoice = 1;
            char charChoice = 'y';

            while (charChoice != 'n')
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");

                    integerChoice = int.Parse(Console.ReadLine());

                    if (integerChoice == 1)
                    {
                        Console.WriteLine("Current balance: " + balance);
                        break;
                    }
                    else if (integerChoice == 2)
                    {
                        Console.Write("Enter the amount you wish to deposit: ");
                        amount = int.Parse(Console.ReadLine());

                        balance = Deposit(amount, balance);
                        Console.WriteLine("Current balance: " + balance);
                        break;
                    }
                    else if (integerChoice == 3)
                    {
                        Console.Write("Enter the amount you wish to withdraw: ");
                        amount = int.Parse(Console.ReadLine());
                        if (amount > balance)
                        {
                            Console.WriteLine("Not enough balance");
                        }
                        else 
                        {
                            balance = Withdraw(amount, balance);
                            Console.WriteLine("Current balance: " + balance);
                            break; 
                        }
                        
                    }
                    else
                    {
                        flag = true;
                        Console.WriteLine("Thank You!");
                        break;
                    }
                }

                if (flag == false)
                {
                    Console.Write("Would you like to perform another transaction (y/n): ");
                    charChoice = char.Parse(Console.ReadLine());
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Thank you!");
            }
        }
        
    static int Deposit(int amount, int balance)
        {
            return amount + balance;
        }

        static int Withdraw(int amount, int balance)
        {
            return ( balance - amount);
        }


    }
}

