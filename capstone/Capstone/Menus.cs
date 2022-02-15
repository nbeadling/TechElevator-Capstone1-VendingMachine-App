using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Menus
    {
        public static void MainMenu()
        {
            PurchaseMenu purchaseMenu = new PurchaseMenu();
            purchaseMenu.GetMenu();

            bool restart = false;
            while (!restart)
            {
                Console.WriteLine("***** Welcome to the Vending Machine ***** \n");
                Console.WriteLine("(1) Display Vending Machine Items ");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Exit \n");
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
                        Console.WriteLine();
                        purchaseMenu.ItemMenu();
                        
                    }
                    else if (userInput == 2)
                    {
                        purchaseMenu.PurchaseMeun();
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the Vending Machine!");
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
