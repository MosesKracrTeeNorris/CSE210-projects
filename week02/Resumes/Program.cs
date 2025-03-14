using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job1._jobTitle = "IT Suport Supervisor";
        Job1._company = "Neturon Technologies Liberia";
        Job1._startYear = 2018;
        Job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "IT Support Supervisor";
        job2._company = "The Farmington Hotel Liberia";
        job2._startYear = 2021;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Moses Kracar-Tee Norris";

        myResume._jobs.Add(job1);
        myResume._jobs.add(job2);
        myResume.Display();
    }
//Console.WriteLine("");
}