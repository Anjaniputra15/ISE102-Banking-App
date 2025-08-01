﻿using BankingApp;

namespace BankingApp
{
    class Program
    {
        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        static void ShowDemoCredentials()
        {
            Console.WriteLine("\n--- Demo Account ---");
            Console.WriteLine("Username: Joe.Doe");
            Console.WriteLine("Password: Password123");
            Console.WriteLine("-------------------\n");
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            while (true)
            {
                Console.WriteLine("Welcome to abc Bank");
                Console.WriteLine("1: Login");
                Console.WriteLine("2: Signup");
                Console.WriteLine("3: Show Demo Credentials");
                Console.WriteLine("4: Quit");
                string choice = GetUserInput("Select Option: ");

                switch (choice)
                {
                    case "1":
                        HandleLogin(bank);
                        break;
                    case "2":
                        HandleSignup(bank);
                        break;
                    case "3":
                        ShowDemoCredentials();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void HandleLogin(Bank bank)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                string username = GetUserInput("Enter username: ");
                string password = GetUserInput("Enter your password: ");

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && bank.Login(username, password))
                {
                    Console.WriteLine($"Welcome {username}");
                    ShowBankMenu();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                    attempts++;
                    if (attempts < 3)
                    {
                        Console.WriteLine("1: Try again");
                        Console.WriteLine("2: Main menu");
                        Console.WriteLine("3: Quit");
                        string retryChoice = GetUserInput("Select option: ");
                        if (retryChoice == "2")
                        {
                            return;
                        }
                        else if (retryChoice == "3")
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have exceeded the maximum number of login attempts.");
                    }
                }
            }
        }

        static void HandleSignup(Bank bank)
        {
            string username = GetUserInput("Enter Username: ");
            string email = GetUserInput("Enter Email: ");
            string ageInput = GetUserInput("Enter Age: ");
            string phone = GetUserInput("Enter Phone: ");
            string password = GetUserInput("Enter Password: ");

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(ageInput) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("All fields are required. Please try again.");
                return;
            }

            if (int.TryParse(ageInput, out int age))
            {
                if (bank.SignUp(username, email, age, phone, password))
                {
                    Console.WriteLine("Signup successful. You can now log in with your new credentials.");
                }
                else
                {
                    Console.WriteLine("Username already exists. Please choose a different username.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a valid number.");
            }
        }

        static void ShowBankMenu()
        {
            while (true)
            {
                Console.WriteLine("1: View Balance");
                Console.WriteLine("2: Deposit");
                Console.WriteLine("3: Withdraw");
                Console.WriteLine("4: Transfer");
                Console.WriteLine("5: Quit");
                string choice = GetUserInput("Select option: ");

                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        Console.WriteLine("This feature will be available in Assessment 3.");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
