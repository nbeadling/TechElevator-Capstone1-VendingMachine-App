using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachineItems
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemType { get; set; }
        public int ItemInventory { get; set; } = 5;

        public List<string> ItemList { get; set; }

        public VendingMachineItems() { }
        public VendingMachineItems(string itemCode, string itemName, decimal itemPrice, string itemType, int itemInventory, List<string> itemList)
        {
            this.ItemCode = itemCode;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.ItemType = itemType;
            this.ItemInventory = itemInventory;
            this.ItemList = itemList;
        }

        public List<string> GetMenu()
        {
            List<string> items = new List<string>();
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string newFileName = Path.Combine(directory, @"..\..\..\VendingMachineItem\vendingmachine.csv");
            string fullPath = Path.GetFullPath(newFileName);
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        items.Add(line + "|" + ItemInventory);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            this.ItemList = items;
            return this.ItemList;
        }

            
        public void ItemMenu()
        {
            foreach (string item in this.ItemList)
            {
                
                Console.WriteLine(item);
                Console.WriteLine($"Number of product remaining: {this.ItemInventory}");
            }
            Console.WriteLine();
        }

        public void GetItems(string selection)
        {
            foreach (string line in this.ItemList)
            {
                if (line.Contains(selection) == true)
                {
                    string[] cutup = line.Split("|");
                    this.ItemCode = cutup[0];
                    this.ItemName = cutup[1];
                    this.ItemPrice = decimal.Parse(cutup[2]);
                    this.ItemType = cutup[3];
                    this.ItemInventory = int.Parse(cutup[4]);
                }
            }

        }

        public List<string> UpdateItemMenu()
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                string item = ItemList[i];
                if (item.Contains(ItemName) == true)
                {
                    ItemInventory -= 1;
                    ItemList[i] = ItemCode + "|" + ItemName + "|" + ItemPrice + "|" + ItemType + "|" + ItemInventory;
                }

            }
            return this.ItemList;

        }


    }
}




