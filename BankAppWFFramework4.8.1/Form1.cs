using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using BankApp;
using BankServerApp;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BankAppWFFramework4._8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInClientSide(Account _account)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BankClientWinForms");
            if (key != null)
            {
                key.SetValue("ActiveAccountName", _account.accountName);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BankAppConfig bankcfg = new BankAppConfig();
            var url = BankAppConfig.bankServiceLink;
            var request = WebRequest.Create(url + $"/login/{textBox1.Text}&{textBox2.Text}&{bankcfg.clientID}");
            request.Method = "GET";
            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();
            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            Account account = JsonConvert.DeserializeObject<Account>(data);
            label1.Text = account.balance.ToString();
            LogInClientSide(account);
            AccountBrowser accountBrowser = new AccountBrowser();
            accountBrowser.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRegisterForm userRegisterForm = new UserRegisterForm();
            userRegisterForm.Show();
            Hide();
        }
    }
}