using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Menus
    {
        public static void MainMenu()
        {
            VendingMachineItems vendingMachineItems = new VendingMachineItems();
            vendingMachineItems.GetMenu();
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
                        Console.WriteLine("Error, please try again \n");
                    }
                    else if (userInput == 1)
                    {
                        Console.WriteLine();
                        vendingMachineItems.ItemMenu();
                    }
                    else if (userInput == 2)
                    {
                        PurchaseMeun();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the Vending Machine!");
                        restart = true;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void PurchaseMeun()
        {
            VendingMachineItems vendingMachineItems = new VendingMachineItems();
            vendingMachineItems.GetMenu();
            Purchase purchase = new Purchase(vendingMachineItems.ItemCode, vendingMachineItems.ItemName, vendingMachineItems.ItemPrice, vendingMachineItems.ItemType, vendingMachineItems.ItemInventory, vendingMachineItems.ItemList);

            Console.WriteLine();
            Console.WriteLine("**** Purchase Menu ****");

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
                        try
                        {
                        Console.Write("feed money: $1, $2, $5, or $10: ");
                        //need a try and catch
                        int moneyInput = int.Parse(Console.ReadLine());
                         if (moneyInput > 0) 
                            { 
                              purchase.InputAmount(moneyInput);
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
                        vendingMachineItems.ItemMenu();

                        Console.Write("Please enter the product code of the item you wish to purchase: ");
                        string selection = Console.ReadLine();
                        vendingMachineItems.GetItems(selection);
                        Console.WriteLine($"The cost of {vendingMachineItems.ItemName} is: ${vendingMachineItems.ItemPrice }");
                        Console.WriteLine();
                        purchase.PriceComparison(selection);
                    }
                    else
                    {
                        Console.WriteLine();
                        purchase.ReturnChange();
                        Menus.MainMenu();
                        restart = true;
                        
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
