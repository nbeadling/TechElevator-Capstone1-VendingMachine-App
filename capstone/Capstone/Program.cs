using System;
using System.IO;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome to the Vending Machine*** \n");
            Menus.MainMenu();
            DisplayMenu.PurchaseMeun();
        }
    }
}
