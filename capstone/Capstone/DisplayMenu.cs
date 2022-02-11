using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class DisplayMenu
    {
        public List<string> items { get; set; }

        public List<string> GetMenu()
        {
            List<string> items = new List<string>();
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
                        items.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            this.items = items;
            return this.items;
        }

        public void ItemMenu()
        {
            foreach (string item in this.items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void PurchaseMeun()
        {
            DisplayMenu displayMenu = new DisplayMenu();

            Purchase purchase = new Purchase();
            Console.WriteLine();
            Console.WriteLine("***Purchase Menu****\n");
            
            bool restart = false;
            while (!restart)
            {
                Console.WriteLine($"Current Balance: ${purchase.InputAmount()} \n");
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
                        decimal moneyInput = decimal.Parse(Console.ReadLine());
                        purchase.InputAmount(moneyInput);
                    
                    }
                    else if (userInput == 2)
                    {
                        displayMenu.GetMenu();
                        displayMenu.ItemMenu();

                        Console.Write("Please Enter number selection of the Product you wish to purchase: ");
                        string selection = Console.ReadLine();

                        Console.WriteLine($"Cost of item: S{purchase.ItemPrice(selection)}");
            
                    }
                    else
                    {
                        purchase.PriceComparison();
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




