using BankApp.DomainLayer.Accounts;

namespace BankApp.DomainLayer.Modes;

public interface IAdminService
{
    OperationResult CreateAccount(string id, string pin, decimal balance);
    Account? FindAccountById(string id);
}