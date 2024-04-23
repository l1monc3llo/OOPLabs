using BankApp.DomainLayer.Accounts;
using BankApp.DomainLayer.Modes;
using BankApp.DomainLayer.Repositories;
using BankApp.DomainLayer.Transactions;

namespace BankApp.ApplicationServices.Modes;
public class UserMode : IUserService
{
    private readonly IAccountRepository _accountRepository;
    private readonly Account _account;

    public UserMode(IAccountRepository accountRepository, string accountId)
    {
        _accountRepository = accountRepository ?? throw new ArgumentNullException(nameof(accountRepository));
        Account account = _accountRepository.FindAccountById(accountId) ?? throw new ArgumentException("Account not found", nameof(accountId));
        _account = account;
    }

    public OperationResult CheckBalance()
    {
        decimal balance = _account.Balance;
        Console.WriteLine($"Balance: {balance}");
        return OperationResult.Success();
    }

    public OperationResult CheckTransactionHistory()
    {
        foreach (BalanceTransaction transaction in _account.Transactions)
        {
            Console.WriteLine($"Type: {transaction.Type}, Amount: {transaction.Amount}, Time: {transaction.Time}");
        }

        return OperationResult.Success();
    }

    public OperationResult DepositMoney(decimal amount)
    {
        try
        {
            _account.Deposit(amount);
            _accountRepository.UpdateAccount(_account);
            Console.WriteLine($"Deposited: {amount}");
            return OperationResult.Success();
        }
        catch (InvalidOperationException ex)
        {
            return OperationResult.Failure($"Error depositing money: {ex.Message}");
        }
    }

    public OperationResult WithdrawMoney(decimal amount)
    {
        try
        {
            _account.Withdraw(amount);
            _accountRepository.UpdateAccount(_account);
            Console.WriteLine($"Withdrawn: {amount}");
            return OperationResult.Success();
        }
        catch (InvalidOperationException ex)
        {
            return OperationResult.Failure($"Error withdrawing money: {ex.Message}");
        }
    }
}