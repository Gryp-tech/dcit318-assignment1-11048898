using System;

public class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.WriteLine("\nEnter the three sides of the triangle:");

        if (double.TryParse(Console.ReadLine(), out double a) &&
            double.TryParse(Console.ReadLine(), out double b) &&
            double.TryParse(Console.ReadLine(), out double c) &&
            a > 0 && b > 0 && c > 0)
        {
            if (a + b > c && a + c > b && b + c > a) // Triangle Inequality
            {
                if (a == b && b == c)
                    Console.WriteLine("Equilateral Triangle\n");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Isosceles Triangle\n");
                else
                    Console.WriteLine("Scalene Triangle\n");
            }
            else
            {
                Console.WriteLine("The values do not form a valid triangle.\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numbers.\n");
        }
    }
}
