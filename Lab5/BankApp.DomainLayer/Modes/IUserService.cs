namespace BankApp.DomainLayer.Modes;

public interface IUserService
{
    OperationResult CheckBalance();
    OperationResult CheckTransactionHistory();
    OperationResult DepositMoney(decimal amount);
    OperationResult WithdrawMoney(decimal amount);
}