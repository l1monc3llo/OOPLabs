namespace BankApp.DomainLayer.Transactions;

public class BalanceTransaction
{
    public BalanceTransaction(decimal amount, BalanceTransactionType type)
    {
        Amount = amount;
        Time = DateTime.Now;
        Type = type;
    }

    public decimal Amount { get; private set; }
    public DateTime Time { get; private set; }
    public BalanceTransactionType Type { get; private set; }
}