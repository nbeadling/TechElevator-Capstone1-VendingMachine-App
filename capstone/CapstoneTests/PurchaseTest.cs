using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class PurchaseTest
    {
        [TestMethod]

        public void CurrentAmount()
        {
            Purchase purchase = new Purchase();
            string param1 = "5";
            decimal inputAmount = decimal.Parse(param1); 
            

            decimal actualValue = purchase.InputAmount(inputAmount);

            Assert.AreEqual(inputAmount, actualValue); 

          

        }

        [TestMethod]
        public void ItemTypeAndMessage()
        {
            Purchase purchase = new Purchase();
            //string param1 = "Chip";
            //string returnMessage = "Crucn Crunch, Yum!";

            //string actualValue = purchase.ItemTypes(param1);
            //string itemCode = "A1";

            
            string itemType = purchase.ItemType;
            string message = purchase.Message;

            
           
            //string actualItemType = purchase.ItemCode;
            
            Assert.AreEqual(itemType, message); 

        }

      

        //[TestMethod]
        //public void PriceComparison()
        //{
        //    Purchase purchase = new Purchase();
        //    string param1 = "A1";
        //    decimal itemPrice = 3.05M;

        //  string actualValue = purchase.PriceComparison(param1, itemPrice);

        //    Assert.AreEqual(itemPrice, actualValue, "additional details");
        //}

    }
}
/*
 * public decimal PriceComparison(string selection)
        {
            GetItems(selection);
            if (base.ItemPrice > this.CurrentAmount && this.ItemInventory > 0 && CheckItem().Contains(selection) == true)
            {
                Console.WriteLine($"The cost of {base.ItemName} is: ${base.ItemPrice } \n");
                Console.WriteLine("Insufficent Funds, Please Add More Money!");
            }
            else if (base.ItemPrice < this.CurrentAmount && this.ItemInventory > 0 && CheckItem().Contains(selection) == true)
            {
                decimal originalAmount = this.CurrentAmount;
                this.CurrentAmount -= base.ItemPrice;
                ItemTypes();
                Console.WriteLine($"The cost of {base.ItemName} is: ${base.ItemPrice } \n");
                Console.WriteLine($"Transcation Complete! {this.Message}");
                Console.WriteLine($"Your remaining balance is: ${ this.CurrentAmount}");
                Console.WriteLine("Thank you for purchasing!");
                AuditLogs.WriteFiles(base.ItemName,base.ItemCode, originalAmount, this.CurrentAmount);
                UpdateItemMenu();
            }
            else
            {
            }
            return this.CurrentAmount;
 * 
 * 
 */