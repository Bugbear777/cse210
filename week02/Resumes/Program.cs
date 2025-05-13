using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobTitle = "Web Developer";
        job1._company = "Intel";
        job1._startYear = 1998;
        job1._endYear = 2024;

        Jobs job2 = new Jobs();
        job2._jobTitle = "Dev Team Manager";
        job2._company = "Microsoft";
        job2._startYear = 2025;
        job2._endYear = 2027;

        Resume myResume = new Resume();
        myResume._name = "Guisseppe Martino";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}