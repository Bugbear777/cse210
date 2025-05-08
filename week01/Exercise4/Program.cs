using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers;
        numbers = new List<int>();
        int digit = -1;

        while (digit != 0)
        {
            Console.WriteLine("Enter a number or enter 0 to stop");
            string user = Console.ReadLine();
            digit = int.Parse(user);
            if (digit != 0)
            {
                numbers.Add(digit);
            }
            
        }
        int total = 0;
        int largest = 0;

        foreach (int number in numbers)
        {
            total += number;
            if(number > largest)
            {
                largest = number;
            }
        }
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The grand total of your numbers is {total}");
        Console.WriteLine($"Your average number is {average}");
        Console.WriteLine($"Your largest number is {largest}");

    }
}