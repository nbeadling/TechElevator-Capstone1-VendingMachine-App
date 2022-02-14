using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Menus
    {
        public static void MainMenu()
        {
            Console.WriteLine("***** Welcome to the Vending Machine ***** \n");
            bool restart = false;
            while (!restart)
            {
                Console.WriteLine("(1) Display Vending Machine Items ");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Exit \n");
                try
                {
                    Console.Write("Please select a number: ");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 3)
                    {
                        Console.WriteLine("Error. Invalid Selection. Please try again \n");
                    }
                    else if (userInput == 1)
                    {
                        Console.WriteLine();
                        
                    }
                    else if (userInput == 2)
                    {
                        PurchaseMeun();
                        Console.WriteLine("***** Welcome to the Vending Machine ***** \n");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the Vending Machine!");
                        restart = true;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Error. Invalid Selection. Please try again \n");
                }
            }
        }

        public static void PurchaseMeun()
        {
            Purchase purchase = new Purchase();
            purchase.GetMenu();

            Console.WriteLine();
            Console.WriteLine("**** Purchase Menu ****");

            bool restart = false;
            while (!restart)
            {
                Console.WriteLine($"Current Balance: ${purchase.CurrentBalance()} \n");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction \n");
                try
                {
                    Console.Write("Please select a number: ");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 3)
                    {
                        Console.WriteLine("Error. Invalid Selection. Please try again \n");
                    }
                    else if (userInput == 1)
                    {
                        try
                        {
                        Console.Write("Please enter in dollar amounts: $");
                        int moneyInput = int.Parse(Console.ReadLine());
                         if (moneyInput > 0) 
                            { 
                              purchase.FeedMoney(moneyInput);
                            }
                        

                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Not a valid amount");
                        }
                       

                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine();
                        purchase.ItemMenu();

                        Console.Write("Please enter the product code of the item you wish to purchase(i.e. A1): ");
                        string selection = Console.ReadLine().ToUpper();
                        Console.WriteLine();
                        purchase.Purchasing(selection);
                    }
                    else
                    {
                        Console.WriteLine();
                        purchase.ReturnChange();
                        restart = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error. Invalid Selection. Please try again \n");
                }

            }

        }
    }
}
