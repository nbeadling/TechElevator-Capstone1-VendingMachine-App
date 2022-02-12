using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class VendingMachineItems
    {
        public List<string> items { get; set; }

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
                        items.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            this.items = items;
            return this.items;
        }

        public void ItemMenu()
        {
            foreach (string item in GetMenu())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        

    }
}




