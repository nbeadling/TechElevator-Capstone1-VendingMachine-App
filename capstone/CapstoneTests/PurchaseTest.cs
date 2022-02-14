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

        public void FeedMoneyTest()
        {
            Purchase purchase = new Purchase();
            decimal param1 = 5;
            decimal inputAmount = param1;
            decimal expectedValue = purchase.CurrentAmount + inputAmount;
            decimal actualValue = purchase.FeedMoney(inputAmount);

            Assert.AreEqual(expectedValue, actualValue); 
        }

        [TestMethod]
        public void ItemTypesTest()
        {
            Purchase purchase = new Purchase(); 
            purchase.ItemType = "Chip";
            purchase.GetMenu();

            string expectedValue = "Crunch Crunch, Yum!";
            string actualValue = purchase.ItemTypes();

            Assert.AreEqual(expectedValue, actualValue); 
        }



        [TestMethod]
        public void PurchasingTest()
        {
            string param1 = "A1";
            decimal itemPrice = 3.05M;
            decimal currentAmount = 8.00M;

            Purchase purchase = new Purchase();
            purchase.GetMenu(); 
           
            purchase.CurrentAmount = currentAmount;
            
            decimal expectedValue = currentAmount - itemPrice; 
            decimal actualValue = purchase.Purchasing(param1);
            
            Assert.AreEqual(expectedValue, actualValue, "additional details...");
        }

        [TestMethod]
        public void ReturnChangeTest()
        {
            decimal currentAmount = 8.95M;

            Purchase purchase = new Purchase();
            purchase.GetMenu();

            purchase.CurrentAmount = currentAmount;

            decimal expectedValue = 0;
            decimal actualValue = purchase.ReturnChange();

            Assert.AreEqual(expectedValue, actualValue, "additional details...");
        }



    }
}
