public abstract class BankAccount
{
    public string AccountNumber { get; }
    public string HolderName { get; }
    public decimal Balance { get; private set; }

    private readonly List<Transaction> _transactions = new();

    protected BankAccount(string accountNumber, string holderName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount, string type = "Deposit")
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        RecordTransaction(type, amount, Balance + amount);
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds!");
        }

        RecordTransaction("Withdrawal",amount, Balance - amount);
    }


    // protected void RecordTransaction(string type, decimal amount)
    // {
    //     _transactions.Add(new Transaction(
    //         DateTime.Now,
    //         type,
    //         amount,
    //         Balance
    //     ));
    // }

    protected void RecordTransaction(string type, decimal amount, decimal newBalance)
    {
        Balance = newBalance;

        _transactions.Add(new Transaction(
            DateTime.Now,
            type,
            amount,
            Balance
        ));
    }

    public void PrintStatement()
    {
        Console.WriteLine("\n======= Bank Account Statement =======");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Holder Name: {HolderName}");
        Console.WriteLine($"Current Balance: {Balance}");

        Console.WriteLine("\n==== Transaction History ====");

        foreach (Transaction transaction in _transactions)
        {
            Console.WriteLine($"{transaction.Date} | {transaction.Type} | Amount: {transaction.Amount} | Balance: {transaction.BalanceAfter}");
        }


    }

}