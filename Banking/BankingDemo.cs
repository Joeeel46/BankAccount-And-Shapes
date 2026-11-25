
public class BankingDemo
{
    public static void Run()
    {
        SavingsAccount savings = new SavingsAccount("S00","Joel",10000,5);
        CurrentAccount current = new CurrentAccount("C00","Joel",5000,5000);

        Console.WriteLine("==== Savings Account ====");

        savings.Deposit(2000);
        savings.Withdraw(1000);

        try
        {
            savings.Deposit(-500);
        }catch(ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            savings.Withdraw(50000);

        }catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        savings.AddInterest();

        Console.WriteLine("==== Current Account ====");

        current.Deposit(3000);
        current.Withdraw(2000);

        current.Withdraw(8000);

        try
        {
            current.Withdraw(10000);
        } catch(InvalidOperationException ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }

        Console.WriteLine("\n==== Savings Account ====");
        savings.PrintStatement();

        Console.WriteLine("\n==== Current Account ====");
        current.PrintStatement();
    }
}