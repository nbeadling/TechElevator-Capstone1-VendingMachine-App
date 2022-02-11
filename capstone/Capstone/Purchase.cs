using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Purchase:DisplayMenu
    {
        public decimal Price { get; set; }

        public decimal CurrentAmount { get; set; }

        public Dictionary<string,decimal> VendingItems { get; set; }


        public Dictionary<string,decimal> vendingItems()
        {
            DisplayMenu displaymenu = new DisplayMenu();
            Dictionary<string, decimal> vendingItems = new Dictionary<string, decimal>();
            foreach (string item in displaymenu.GetMenu())
            {
                string[] cutItem = item.Split("|");
                vendingItems[cutItem[0]] = decimal.Parse(cutItem[2]);
            }
            this.VendingItems= vendingItems;
            return this.VendingItems;
        }

        public decimal InputAmount(decimal moneyInput)
        {
            this.CurrentAmount += moneyInput;
            Console.WriteLine();
            return this.CurrentAmount;
        }
        public decimal InputAmount()
        {
            Console.WriteLine();
            return this.CurrentAmount;
        }
        public decimal ItemPrice(string selection)
        {
            vendingItems();
            decimal itemPrice = this.VendingItems[selection];
            this.Price = itemPrice;
            return this.Price;
        }

        public void PriceComparison()
        {
            if(this.Price > this.CurrentAmount)
            {
                Console.WriteLine("Insufficent Funds, Please Add More Money!");
                
            }
            else
            {
                this.CurrentAmount -= this.Price;
                Console.WriteLine("Transcation Complete");
                Console.WriteLine($"Current Balance: {this.CurrentAmount}");
                Console.WriteLine("Thank you for purchasing!");
                Console.Write("To exit. Enter 3 again: ");
                int userExit = int.Parse(Console.ReadLine());
                if (userExit == 3)
                {
                    ReturnChange();
                }
            }
        }

        public void ReturnChange()
        {
            decimal quarter = 0.25M;
            decimal nickel = 0.05M;
            decimal dime = 0.10M;

            decimal quartersReturn = 0;
            decimal dimesReturn = 0;
            decimal nicklesReturn = 0;

            while (this.CurrentAmount != 0)
            {
                if (this.CurrentAmount >= 0.25M)
                {
                    quartersReturn = CurrentAmount / quarter;
                    this.CurrentAmount = this.CurrentAmount - ((int)quartersReturn * 0.25M);
                }
                else if (this.CurrentAmount >= .10M)
                {
                    dimesReturn = this.CurrentAmount / dime;
                    this.CurrentAmount = this.CurrentAmount - ((int)dimesReturn * 0.10M);
                }
                else
                {
                    nicklesReturn = CurrentAmount / nickel;
                    this.CurrentAmount = this.CurrentAmount - ((int)nicklesReturn * 0.05M);
                }
            }
            

            Console.WriteLine($"Changed return in {(int)quartersReturn} quarters, {(int)dimesReturn} dimes, {(int)nicklesReturn} nickels");
            Console.WriteLine("Thank you for using the Vending Machine!");
        }
    }
}
