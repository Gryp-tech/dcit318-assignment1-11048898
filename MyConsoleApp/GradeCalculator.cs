using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.Write("\nEnter numerical grade (0–100): ");
        if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
        {
            string letter = grade >= 90 ? "A" :
                            grade >= 80 ? "B" :
                            grade >= 70 ? "C" :
                            grade >= 60 ? "D" : "F";

            Console.WriteLine($"Letter grade: {letter}\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Enter a number between 0 and 100.\n");
        }
    }
}
