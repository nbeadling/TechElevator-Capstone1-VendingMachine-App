using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class DisplayMenu
    {
        public static void GetMenu()
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string newFileName = Path.Combine(directory, @"..\..\..\VendingMachineItem\vendingmachine.csv");
            string fullPath = Path.GetFullPath(newFileName);

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PurchaseMeun()
        {
            Console.WriteLine();
            Console.WriteLine("***Purchase Menu****\n");
            int currentAmount = 0;
            bool restart = false;
            while (!restart)
            {
                Console.WriteLine($"Current Balance: ${currentAmount}.00 \n");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction \n");
                try
                {
                    Console.Write("Please select a number: ");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 3)
                    {
                        Console.WriteLine("Error, please try again \n");
                    }
                    else if (userInput == 1)
                    {
                        Console.Write("feed money: $1, $2, $5, or $10: ");
                        int moneyInput = int.Parse(Console.ReadLine());
                        currentAmount += moneyInput;
                        Console.WriteLine();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine();
                        DisplayMenu.GetMenu();
                        Console.Write("Select an item: ");
                        string selectedItem = Console.ReadLine();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Transcation Complete");
                        Console.WriteLine("Thank you for using the Vending Machine!");
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}




