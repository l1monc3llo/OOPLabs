using BankApp.DomainLayer.Transactions;

namespace BankApp.DomainLayer.Accounts;

public class Account
{
    private readonly List<BalanceTransaction> _transactions = new List<BalanceTransaction>();

    public Account(string id, string pin, decimal balance)
    {
        Id = id;
        ValidatePin(pin);
        Pin = pin;
        Balance = balance;
    }

    public string Id { get; private set; }
    public string Pin { get; private set; }
    public decimal Balance { get; private set; }
    public IReadOnlyList<BalanceTransaction> Transactions => _transactions;

    public static void ValidatePin(string pin)
    {
        if (!int.TryParse(pin, out int parsedPin) || parsedPin < 0 || parsedPin > 9999)
        {
            throw new ArgumentException("PIN must be a 4-digit number.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new InvalidOperationException("Balance is below zero");
        }

        Balance -= amount;
        _transactions.Add(new BalanceTransaction(amount, BalanceTransactionType.Withdraw));
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        _transactions.Add(new BalanceTransaction(amount, BalanceTransactionType.Deposit));
    }
}