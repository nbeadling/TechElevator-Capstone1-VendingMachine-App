using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Purchase:VendingMachineItems
    {
        public decimal Price { get; set; }

        public decimal CurrentAmount { get; set; }

        public string ItemType { get; set; }

        public int AvailableItem { get; set; } = 5;

        public string ItemName { get; set; }

        public Dictionary<string,decimal> VendingItems { get; set; }

        public Dictionary<string, string> VendingTypes { get; set; }

        public Dictionary<string, int> ItemAmount { get; set; }

        public Dictionary<string, string> ItemsName { get; set; }



        public Dictionary<string,decimal> VendingItem()
        {
            VendingMachineItems vendingMachineItems = new VendingMachineItems();

            Dictionary<string, decimal> vendingItems = new Dictionary<string, decimal>();
            
            foreach (string item in vendingMachineItems.GetMenu())
            {
                string[] cutItem = item.Split("|");
                vendingItems[cutItem[0]] = decimal.Parse(cutItem[2]);
            }
            this.VendingItems= vendingItems;
            return this.VendingItems;
        }

        public decimal ItemPrice(string selection)
        {
            VendingItem();
            decimal itemPrice = this.VendingItems[selection];
            this.Price = itemPrice;
            return this.Price;
        }

        public Dictionary<string, string> VendingType()
        {
            VendingMachineItems vendingMachineItems = new VendingMachineItems();

            Dictionary<string, string> vendingTypes = new Dictionary<string, string>();

            foreach (string item in vendingMachineItems.GetMenu())
            {
                string[] cutItem = item.Split("|");
                vendingTypes[cutItem[0]] = cutItem[3];
            }
            this.VendingTypes = vendingTypes;
            return this.VendingTypes;
        }

        public string ItemTypes(string selection)
        {
            VendingType();
            if (this.VendingTypes[selection] == "Chip")
            {
                this.ItemType = "Crunch Crunch, Yum!";
            } 
            else if (this.VendingTypes[selection] == "Candy")
            {
                this.ItemType = "Munch Munch, Yum!";
            }
            else if (this.VendingTypes[selection] == "Drink")
            {
                this.ItemType = "Glug Glug, Yum!";
            }
            else if (this.VendingTypes[selection] == "Gum")
            {
                this.ItemType = "Chew Chew, Yum!";
            }
            return this.ItemType;
        }


        public Dictionary<string, string> VendingName()
        {
            VendingMachineItems vendingMachineItems = new VendingMachineItems();

            Dictionary<string, string> vendingNames = new Dictionary<string, string>();

            foreach (string item in vendingMachineItems.GetMenu())
            {
                string[] cutItem = item.Split("|");
                vendingNames[cutItem[0]] = cutItem[1];
            }
            this.ItemsName = vendingNames;
            return this.ItemsName;
        }

        public string Name(string selection)
        {
            VendingName();
            string name = this.ItemsName[selection];
            this.ItemName = name;
            return this.ItemName;
        }

        public Dictionary<string, int> ItemsAmount()
        {
            VendingMachineItems vendingMachineItems = new VendingMachineItems();

            Dictionary<string, int> itemsAmount = new Dictionary<string, int>();

            foreach (string item in vendingMachineItems.GetMenu())
            {
                string[] cutItem = item.Split("|");
                itemsAmount[cutItem[0]] = this.AvailableItem;
            }
            this.ItemAmount = itemsAmount;
            return this.ItemAmount;
        }

        


        public decimal InputAmount(decimal moneyInput)
        {
            this.CurrentAmount += moneyInput;
            return this.CurrentAmount;
        }
        public decimal InputAmount()
        {
            Console.WriteLine();
            return this.CurrentAmount;
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
                Console.WriteLine($"Transcation Complete! {this.ItemType}");
                Console.WriteLine($"Your remaining balance is: ${ this.CurrentAmount}");
                Console.WriteLine("Thank you for purchasing!");
                
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
            

            Console.WriteLine($"Change return:  {(int)quartersReturn} quarters, {(int)dimesReturn} dimes, {(int)nicklesReturn} nickels");
            Console.WriteLine("Thank you for using the Vending Machine! \n");
        }
    }
}
