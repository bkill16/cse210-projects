using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

    int total = numbers.Sum();
    Console.WriteLine($"The sum is: {total}");
    double avg = Queryable.Average(numbers.AsQueryable());
    Console.WriteLine($"The average is: {avg}");
    int largest = numbers.Max();
    Console.WriteLine($"The largest number is: {largest}");
    }
}