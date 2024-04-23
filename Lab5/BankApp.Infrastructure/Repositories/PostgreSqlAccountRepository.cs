using System.Data;
using BankApp.DomainLayer.Accounts;
using BankApp.DomainLayer.Repositories;
using Npgsql;

namespace BankApp.Infrastructure.Repositories;
public class PostgreSqlAccountRepository : IAccountRepository
{
    private readonly string _connectionString;

    public PostgreSqlAccountRepository(string connectionString)
    {
        _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
    }

    public void AddAccount(Account account)
    {
        if (account is null)
        {
            throw new ArgumentNullException(nameof(account));
        }

        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = new NpgsqlCommand("INSERT INTO accounts (id, pin, balance) VALUES (@id, @pin, @balance)", connection, transaction))
                    {
                        command.Parameters.AddWithValue("id", account.Id);
                        command.Parameters.AddWithValue("pin", account.Pin);
                        command.Parameters.AddWithValue("balance", account.Balance);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new DataException("Error while adding an account to the database", ex);
                }
            }
        }
    }

    public void UpdateAccount(Account account)
    {
        if (account is null)
        {
            throw new ArgumentNullException(nameof(account));
        }

        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();

            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    using (var command = new NpgsqlCommand("UPDATE accounts SET pin = @pin, balance = @balance WHERE id = @id", connection, transaction))
                    {
                        command.Parameters.AddWithValue("id", account.Id);
                        command.Parameters.AddWithValue("pin", account.Pin);
                        command.Parameters.AddWithValue("balance", account.Balance);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new DataException("Error while updating an account in the database", ex);
                }
            }
        }
    }

    public Account? FindAccountById(string id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();

            using (var command = new NpgsqlCommand("SELECT id, pin, balance FROM accounts WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("id", id);

                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Account(reader.GetString(0), reader.GetString(1), reader.GetDecimal(2));
                    }
                }
            }
        }

        Console.WriteLine("Account is not found");
        return null;
    }
}
