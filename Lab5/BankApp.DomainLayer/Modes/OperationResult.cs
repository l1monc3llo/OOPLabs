using BankApp.DomainLayer.Accounts;

namespace BankApp.DomainLayer.Modes;

public class OperationResult
{
    private OperationResult(bool isSuccess, string message, Account? account = null)
    {
        IsSuccess = isSuccess;
        Message = message;
        Account = account;
    }

    public bool IsSuccess { get; }
    public string Message { get; }
    public Account? Account { get; }

    public static OperationResult Success(Account? account = null) => new OperationResult(true, string.Empty, account);
    public static OperationResult Failure(string message) => new OperationResult(false, message);
}