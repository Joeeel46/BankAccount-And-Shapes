class Program
{
    static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n====== OOPS Practice ======");
            Console.WriteLine("1. Banking Demo");
            Console.WriteLine("2. Shapes Demo");
            Console.WriteLine("3. Exit");

            Console.Write("Enter a choice: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Banking Demo Selected");
                    BankingDemo.Run();
                    break;
                case "2":
                    Console.WriteLine("Shapes Demo Selected");
                    ShapesDemo.Run();
                    break;
                case "3":
                    isRunning = false;
                    Console.WriteLine("Exiting Application....");
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please try again.");
                    break;
            }
        }
    }
}


