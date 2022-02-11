using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Purchase
    {
        public decimal Price { get; set; }

        public decimal CurrentAmount { get; set;  }


        Dictionary<string, decimal> vendingItems = new Dictionary<string, decimal>()
        {
            {"A1", 3.05M },
            {"A2", 1.45M },
            {"A3", 2.75M },
            {"A4", 3.65M},
            {"B1", 1.80M },
            {"B2", 1.50M },
            {"B3", 1.50M },
            {"B4", 1.75M },
            {"C1", 1.25M },
            {"C2", 1.50M },
            {"C3", 1.50M },
            {"C4", 1.50M },
            {"D1", 0.85M },
            {"D2", 0.95M },
            {"D3", 0.75M },
            {"D4", 0.75M }
        };

        public decimal InputAmount(int moneyInput)
        {
            //int currentAmount = 0;
            //Console.Write("feed money: $1, $2, $5, or $10: ");
            //int moneyInput = int.Parse(Console.ReadLine());
            this.CurrentAmount += moneyInput;
            Console.WriteLine();
            return this.CurrentAmount;
        }
        public decimal InputAmount()
        {
            //int currentAmount = 0;
            //Console.Write("feed money: $1, $2, $5, or $10: ");
            //int moneyInput = int.Parse(Console.ReadLine());
            //this.CurrentAmount += moneyInput;
            Console.WriteLine();
            return this.CurrentAmount;
        }
        public  decimal  ItemPrice(string selection)
        {
            this.Price = vendingItems[selection];
            return this.Price; 
        }

        public void  PriceComparison()
        {
            if(this.Price > this.CurrentAmount)
            {
                Console.WriteLine("Insufficent Funds, Please Add More Money!");
                
            }
            else
            {
                Console.WriteLine("Transcation Complete");
                Console.WriteLine("Thank you for using the Vending Machine!");
            }
        }


    }
}
