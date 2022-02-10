using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class Beverages:VendingMachine
    {
        public Beverages() : base() { }

        public Beverages(string itemName, decimal price) : base(itemName, price) { }

        //public override string GetItem()
        //{
        //    string directory = AppDomain.CurrentDomain.BaseDirectory;
        //    string newFileName = Path.Combine(directory, @"..\..\..\VendingMachineItem\vendingmachine.csv");
        //    string fullPath = Path.GetFullPath(newFileName);
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(fullPath))
        //        {
        //            while (!sr.EndOfStream)
        //            {
        //                string line = sr.ReadLine();
        //                if (line.Contains("Drink") == true)
        //                {

        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
