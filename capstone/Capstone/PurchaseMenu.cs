using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenu:Purchase
    {
        public void PurchaseMeun()
        {
            Console.WriteLine();
            Console.WriteLine("**** Purchase Menu ****");

            bool restart = false;
            while (!restart)
            {
                Console.WriteLine($"Current Balance: ${CurrentBalance()} \n");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction \n");
                try
                {
                    Console.Write("Please select a number: ");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput < 1 || userInput > 3)
                    {
                        Console.WriteLine("Invalid Selection. Please try again \n");
                    }
                    else if (userInput == 1)
                    {
                        try
                        {
                            Console.Write("Please enter in whole dollar amounts(i.e. $5): $");
                            int moneyInput = int.Parse(Console.ReadLine());
                            if (moneyInput >= 0)
                            {
                                FeedMoney(moneyInput);
                            }
                            else
                            {
                                Console.WriteLine("Amount can't be less than 0");
                            }


                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Not a valid amount. Please try again");
                        }

                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine();
                        ItemMenu();

                        Console.Write("Please enter the product code of the item you wish to purchase(i.e. A1): ");
                        string selection = Console.ReadLine().ToUpper();
                        Console.WriteLine();
                        Purchasing(selection);
                    }
                    else
                    {
                        Console.WriteLine();
                        ReturnChange();
                        restart = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Selection. Please try again \n");
                }

            }

        }
    }
}
