using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public string ItemName { get; set; }

        public decimal Price { get; set; }

        public VendingMachine()
        {

        }
        public VendingMachine(string itemName, decimal price)
        {
            this.ItemName = itemName;
            this.Price = price;
        }

        public virtual string GetItem()
        {
            return ItemName;
        }

        public virtual decimal GetPrice()
        {
            return Price;
        }

    }
}
