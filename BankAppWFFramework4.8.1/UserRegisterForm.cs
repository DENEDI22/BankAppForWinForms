using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using BankApp;
using BankServerApp;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace BankAppWFFramework4._8._1;

public partial class UserRegisterForm : Form
{
    public UserRegisterForm()
    {
        InitializeComponent();
    }
    
    private void AccountBrowser_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.OpenForms[0].Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        BankAppConfig bankcfg = new BankAppConfig();
        var url = BankAppConfig.bankServiceLink;
        var request = WebRequest.Create(url + $"/register/{textBox1.Text}&{textBox2.Text}&{bankcfg.clientID}");
        request.Method = "GET";
        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();
        using var reader = new StreamReader(webStream);
        var data = reader.ReadToEnd();
        Account account = JsonConvert.DeserializeObject<Account>(data);
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BankClientWinForms");
        if (key != null)
        {
            key.SetValue("ActiveAccountName", account.accountName);
        }
        AccountBrowser accountBrowser = new AccountBrowser();
        accountBrowser.Show();
        Hide();
    }
}