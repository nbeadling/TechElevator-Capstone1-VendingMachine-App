using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 

namespace Capstone
{
    public class AuditLogs : Purchase
    {

        public AuditLogs(string itemCode, string itemName, decimal itemPrice, string itemType, int itemInventory, List<string> itemList, decimal currentAmount)
           : base(itemCode, itemName, itemPrice, itemType, itemInventory, itemList, currentAmount) { }

        public void WriteFiles() 
        { 
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        string newFileName = Path.Combine(directory, @"..\..\..\VendingMachineItem\log.txt");
        string fullPath = Path.GetFullPath(newFileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(CurrentAmount);
                }

            }
            catch
            {

            }
        }

    }
}
