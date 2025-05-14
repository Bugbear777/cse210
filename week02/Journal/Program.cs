using System;

class Program
{
    static void Main(string[] args)
    {
         bool running = true;
         Journal journal = new Journal();
         PromptGenerator promptGen = new PromptGenerator();
         while (running)
         {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            string response = Console.ReadLine();
            int answer = int.Parse(response);
            if(answer == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                string journalResponse = Console.ReadLine();
                journal.AddEntry(new JournalEntry(prompt, journalResponse));
                //break;
            }
            else if (answer ==2)
            {
                journal.DisplayEntries();
                //break;
            }
            else if (answer ==4)
            {
                Console.Write("Enter filename to save: ");
                string savefile = Console.ReadLine();
                journal.SaveToFile(savefile);
                //break;
            }
            else if (answer ==3)
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                //break;
            }
            else if (answer ==5)
            {
                Console.WriteLine("Quitting...");
                running = false;
                //break;
            }
            else
            {
                Console.WriteLine("Invalid response, please enter a number between 1 and 5");
            }
         }
    }
}