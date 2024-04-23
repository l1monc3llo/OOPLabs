using BankApp.DomainLayer.Accounts;
using BankApp.DomainLayer.Modes;
using BankApp.DomainLayer.Repositories;

namespace BankApp.ApplicationServices.Modes;

public class AdminMode : IAdminService
{
    private readonly IAccountRepository _accountRepository;

    public AdminMode(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository ?? throw new ArgumentNullException(nameof(accountRepository));
    }

    public OperationResult CreateAccount(string id, string pin, decimal balance)
    {
        var newAccount = new Account(id, pin, balance);
        _accountRepository.AddAccount(newAccount);
        Console.WriteLine("Account created successfully.");
        return OperationResult.Success();
    }

    public Account? FindAccountById(string id)
    {
        Account? account = _accountRepository.FindAccountById(id);

        if (account is null)
        {
            Console.WriteLine("Account not found.");
            return null;
        }

        Console.WriteLine("Account found successfully.");
        return account;
    }
}