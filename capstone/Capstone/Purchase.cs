﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Purchase:VendingMachineItems
    {
        public string Message { get; set; }

        public decimal CurrentAmount { get; set; }

        public Purchase (string itemCode, string itemName, decimal itemPrice, string itemType, int itemInventory, List<string> itemList)
            : base(itemCode, itemName, itemPrice, itemType, itemInventory, itemList) { }


        public string ItemTypes()
        {
            if (base.ItemType  == "Chip")
            {
                this.Message = "Crunch Crunch, Yum!";
            }
            else if (base.ItemType == "Candy")
            {
                this.Message = "Munch Munch, Yum!";
            }
            else if (base.ItemType == "Drink")
            {
                this.Message = "Glug Glug, Yum!";
            }
            else if (base.ItemType == "Gum")
            {
                this.Message = "Chew Chew, Yum!";
            }
            return this.Message;
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


        public decimal PriceComparison(string selection)
        {
            GetItems(selection);
            if (base.ItemPrice > this.CurrentAmount)
            {
                Console.WriteLine("Insufficent Funds, Please Add More Money!");

            }
            else
            {
                this.CurrentAmount -= base.ItemPrice;
                ItemTypes();
                Console.WriteLine($"Transcation Complete! {this.Message}");
                Console.WriteLine($"Your remaining balance is: ${ this.CurrentAmount}");

                Console.WriteLine("Thank you for purchasing!");
                UpdateItemMenu();
            }
            return this.CurrentAmount;

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