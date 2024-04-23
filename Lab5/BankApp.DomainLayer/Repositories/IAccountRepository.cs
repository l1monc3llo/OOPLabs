using BankApp.DomainLayer.Accounts;

namespace BankApp.DomainLayer.Repositories;

public interface IAccountRepository
{
    void AddAccount(Account account);
    void UpdateAccount(Account account);
    Account? FindAccountById(string id);
}