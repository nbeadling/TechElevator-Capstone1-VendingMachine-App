using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class DisplayMenu
    {
        public static void ReadFile()
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
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PurchaseMeun()
        {
            int moneyInput = 0;
            bool restart = false;
            while (!restart)
            {
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
                        moneyInput = int.Parse(Console.ReadLine());
                        PurchaseMeun();
                        Console.WriteLine($"Current Money: {moneyInput}");
                    }
                    else if (userInput == 2)
                    {
                        DisplayMenu.ReadFile(); 

                        //Added the below code (Nick's Notes)
                        Console.WriteLine("Please Enter number selection of the Product you wish to purchase: ");
                        string selection = Console.ReadLine();
                      try
                      {


                    if (selection == "A1" || selection == "A2" || selection == "A3" || selection == "A4")
                    {
                        //Call the Chip Method That we create? 
                    }

                    else if (selection == "B1" || selection == "B2" || selection == "B3" || selection == "B4")
                    {
                        //Call the Candy Method that we create? 
                    }

                    else if (selection == "C1" || selection == "C2" || selection == "C3" || selection == "C4")
                    {
                        //Call the Beveragle Method we create? 
                    }

                    else if (selection == "D1 " || selection == "D2" || selection == "D3" || selection == "D4")
                    {
                        //call the Gum method we create? 
                    }
                    else
                    {
                        Console.WriteLine("Not Valid Selection");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

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




