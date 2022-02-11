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
                        //availableamount???
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
            Purchase purchase = new Purchase();
            Console.WriteLine();
            Console.WriteLine("***Purchase Menu****\n");
            
            bool restart = false;
            while (!restart)
            {
                Console.WriteLine($"Current Balance: ${purchase.InputAmount()}.00 \n");
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
                        purchase.InputAmount(moneyInput);
                    
                    }
                    else if (userInput == 2)
                    {
                        DisplayMenu.GetMenu();

                        //Added the below code (Nick's Notes)
                        Console.WriteLine("Please Enter number selection of the Product you wish to purchase: ");
                        string selection = Console.ReadLine();

                        
                        purchase.ItemPrice(selection);
                        Console.WriteLine($"Cost of item: {purchase.ItemPrice(selection)}");
            
                    }
                    else
                    {

                        purchase.PriceComparison();
                        //Console.WriteLine("Transcation Complete");
                        //Console.WriteLine("Thank you for using the Vending Machine!");
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




