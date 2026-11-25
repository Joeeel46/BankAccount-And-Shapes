

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; }

    public SavingsAccount(
        string accountNumber,
        string holderName,
        decimal initialBalance,
        decimal interestRate
    ) : base(accountNumber, holderName, initialBalance)
    {
        if (interestRate < 0)
        {
            throw new ArgumentException("Interest rate cannot be negative.");
        }
        InterestRate = interestRate;
    }

    public void AddInterest()
    {
        decimal interest = Balance * InterestRate / 100;

        Deposit(interest, "Intrest");
    }
}