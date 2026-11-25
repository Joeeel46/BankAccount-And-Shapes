public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; }

    public CurrentAccount(
        string accountNumber,
        string holderName,
        decimal initialBalance,
        decimal overdraftLimit
    ) : base(accountNumber, holderName, initialBalance)
    {
        if (overdraftLimit < 0)
        {
            throw new ArgumentException("Overdraft limit cannot be negative.");
        }

        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be greater than zero.");
        }

        if (Balance - amount < -OverdraftLimit)
        {
            throw new InvalidOperationException("Overdraft limit exceeded!");
        }

        // decimal newBalance = Balance - amount;

        RecordTransaction("Withdrawal", amount, Balance - amount);
    }
}