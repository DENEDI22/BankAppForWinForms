using System;
using Microsoft.Win32;

namespace BankApp
{
    public class BankAppConfig
    {
        public const string bankServiceLink = "https://26.18.53.143:7209/BankServer";
        public Int64 clientID;
        public string currentAccountName;

        public BankAppConfig()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BankClientWinForms");
            if (key != null)
            {
                try
                {
                    clientID = Int64.Parse(key.GetValue("ClientID").ToString());
                }
                catch (Exception e)
                {
                    Random random = new Random();
                    clientID = random.Next(Int32.MinValue, Int32.MaxValue) +
                               random.Next(Int32.MinValue, Int32.MaxValue);
                    clientID = Math.Abs(clientID);
                    key.SetValue("ClientID", clientID);
                }

                currentAccountName = (string)key.GetValue("ActiveAccountName");
            }

            key.Close();
        }
    }
}