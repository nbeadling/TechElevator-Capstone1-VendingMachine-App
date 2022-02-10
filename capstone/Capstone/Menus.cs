﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Menus
    {
        public static void MainMenu()
        {
            bool restart = false;
            while (!restart)
            {
                Console.WriteLine("Welcome to the Vending Machine");
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
                        DisplayMenu.ReadFile();
                        break;
                    }
                    else if (userInput == 2)
                    {
                        DisplayMenu.PurchaseMeun();
                        break;
                    }
                    else
                    {
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