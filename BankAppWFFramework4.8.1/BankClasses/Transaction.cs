using System;

namespace BankServerApp;

[Serializable]
public struct Transaction
{
    public long transactionID;
    public int transactionAmount;
    public TransactionStatus transactionStatus;
    public string recieverAccountName, senderAccountName;
    public DateTime dateOfTransaction;

    public Transaction(int TransactionAmount, TransactionStatus TransactionStatus, long TransactionID,
        string? RecieverAccountName, string? SenderAccountName, DateTime DateOfTransaction)
    {
        transactionID = TransactionID;
        transactionAmount = TransactionAmount;
        transactionStatus = TransactionStatus;
        recieverAccountName = RecieverAccountName;
        senderAccountName = SenderAccountName;
        dateOfTransaction = DateOfTransaction;
    }

    public override string ToString()
    {
        return
            $"{transactionAmount} transferred from {senderAccountName} to {recieverAccountName}.\nDate: {dateOfTransaction}\nStatus: {transactionStatus.ToString()}";
    }
}