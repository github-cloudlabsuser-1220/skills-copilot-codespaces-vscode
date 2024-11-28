using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter the number of elements:");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        int[] arr = new int[n];
        Console.WriteLine($"Enter {n} integers:");

        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        int total = Sum(arr);

        Console.WriteLine("Sum of the numbers: " + total);
    }

    static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}