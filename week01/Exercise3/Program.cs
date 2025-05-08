using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number");
        //string number = Console.ReadLine();
        //int magic_number = int.Parse(number);
        int guess = 0;
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        while (guess != magic_number)
        {
            Console.WriteLine("Guess the magic number.");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You did it!!!");
        Console.WriteLine("Would you like to play again?");
        string response = Console.ReadLine();
        if(response == "yes")
        {
            guess = 0;
        }
    }
}