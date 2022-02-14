using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 

namespace Capstone
{
    public class AuditLogs
    {
        public static void WriteFiles(string action, decimal moneyInput, decimal currentAmount) 
        { 
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        string newFileName = Path.Combine(directory, @"..\..\..\VendingMachineItem\log.txt");
        string fullPath = Path.GetFullPath(newFileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine($"{DateTime.Now}   {action}        Available Balance:${moneyInput}   Current Balace:${currentAmount}");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteFiles(string action,string code, decimal moneyInput, decimal currentAmount)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string newFileName = Path.Combine(directory, @"..\..\..\VendingMachineItem\log.txt");
            string fullPath = Path.GetFullPath(newFileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine($"{DateTime.Now}   {action} {code}   Available Balance:${moneyInput}   Current Balance:${currentAmount}");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
