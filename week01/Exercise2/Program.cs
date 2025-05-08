using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string user_inpuit = Console.ReadLine();
        int percentage = int.Parse(user_inpuit);
        string letter="";
        string message = "";
        string sign = "";
        if(percentage >= 60)
        {
            if(percentage >= 70)
            {
                if(percentage >= 80)
                {
                    if(percentage >=90)
                    {
                        letter = "A";
                    }
                    else
                    {
                        letter = "B";
                    }
                }
                else
                {
                    letter = "C";
                }
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }
        if (percentage >= 70)
        {
            message = "Congrats you passed";
        }
        else
        {
            message = "Better luck next time";
        }
        if(letter != "F")
        {
            int last_digit = percentage % 10;
            if(last_digit >=7 && letter != "A")
            {
                sign = "+";
            }
            else if (last_digit <=3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your grade is: {letter}{sign}. {message}");
    }
}