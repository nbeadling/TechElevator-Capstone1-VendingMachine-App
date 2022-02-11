using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        //Property
        public string ItemName { get;}

        public decimal Price { get; }

        public int CurrentBalance { get;}

        //Constructor
        public VendingMachine()
        {
        }

        public VendingMachine(string itemName, decimal price)
        {
            this.ItemName = itemName;
            this.Price = price;
        }

        //Method
        public virtual string GetItem()
        {
            return ItemName;
        }
       
        public virtual decimal GetPrice()
        {
            return Price;
        }

        public virtual decimal BalanceCalcualtion()
        {
            return CurrentBalance;
        }
    }
}
