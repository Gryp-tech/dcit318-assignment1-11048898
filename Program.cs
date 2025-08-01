using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("====== DCIT318 Assignment 1 ======");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    TicketPriceCalculator.Run();
                    break;
                case "3":
                    TriangleTypeIdentifier.Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
        }
    }
}
