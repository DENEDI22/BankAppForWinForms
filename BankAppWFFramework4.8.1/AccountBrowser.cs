using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Timers;
using System.Windows.Forms;
using BankApp;
using BankServerApp;
using Newtonsoft.Json;

namespace BankAppWFFramework4._8._1;

public partial class AccountBrowser : Form
{
    private Transaction[] transactions;
    private int currentSelectedTransaction;

    public AccountBrowser()
    {
        InitializeComponent();
    }

    private void timer1_Elapsed(object sender, ElapsedEventArgs e)
    {
        UpdateTransactionsList();
    }

    private void UpdateTransactionsList()
    {
        BankAppConfig bankcfg = new BankAppConfig();
        var url = BankAppConfig.bankServiceLink;
        var request = WebRequest.Create(url + $"/transactions/{bankcfg.currentAccountName}");
        request.Method = "GET";
        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();
        using var reader = new StreamReader(webStream);
        var data = reader.ReadToEnd();
        transactions = JsonConvert.DeserializeObject<Transaction[]>(data);
        List<string> transactionNames = new List<string>();
        transactions.ToList().ForEach(x => transactionNames.Add($"{x.recieverAccountName} <= {x.transactionAmount}"));
        listBox1.Items.Clear();
        listBox1.Items.AddRange(transactionNames.ToArray());
        listBox1.SelectedIndex = currentSelectedTransaction;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        label4.Text = transactions[listBox1.SelectedIndex].ToString();
        currentSelectedTransaction = listBox1.SelectedIndex;
    }

    private void AccountBrowser_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void AccountBrowser_Load(object sender, EventArgs e)
    {
        UpdateAccountInfo();
        UpdateTransactionsList();
    }

    private void UpdateAccountInfo()
    {
        BankAppConfig bankcfg = new BankAppConfig();
        var url = BankAppConfig.bankServiceLink;
        var request = WebRequest.Create(url + $"/login/{bankcfg.currentAccountName}&{0}&{bankcfg.clientID}");
        request.Method = "GET";
        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();
        using var reader = new StreamReader(webStream);
        var data = reader.ReadToEnd();
        Account account = JsonConvert.DeserializeObject<Account>(data);
        richTextBox1.Text = $"Hello, {account.accountName}!\nYour account balance is: {account.balance}.";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        BankAppConfig bankcfg = new BankAppConfig();
        var url = BankAppConfig.bankServiceLink;
        var request =
            WebRequest.Create(url + $"/newtransaction/{textBox2.Text}&{textBox1.Text}&{bankcfg.currentAccountName}");
        request.Method = "GET";
        using var webResponse = request.GetResponse();
        using var webStream = webResponse.GetResponseStream();
        using var reader = new StreamReader(webStream);
        int resultCode = Int32.Parse(reader.ReadToEnd());
        switch ((TransactionStatus)resultCode)
        {
            case TransactionStatus.Succeed:
                MessageBox.Show("Transaction Successfull!", "Transfer report", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                UpdateAccountInfo();
                UpdateTransactionsList();
                break;
            case TransactionStatus.NotEnoughMoney:
                MessageBox.Show("You do not have enough money.", "Transfer report", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                break;
            case TransactionStatus.ReceiverNumberNotFound:
                MessageBox.Show("Receiver username not found. Check spelling.", "Transfer report", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                break;
            case TransactionStatus.DeviceCodeExpired:
                //TODO make device expiration period for security reasons
                break;
            case TransactionStatus.FailedForOtherReason:
                MessageBox.Show("Something happened. We are working on it. Sorry.", "Transfer report",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            case TransactionStatus.InProgress:
                //TODO Leave something here msgbox, processing, etc.
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        textBox1.Text = String.Empty;
        textBox2.Text = String.Empty;
    }
}