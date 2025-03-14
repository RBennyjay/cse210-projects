using System;

class Program
{
    static void Main(string[] args)
    {
        // First job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Second job instance
        Job job2 = new Job();
        job2._jobTitle = "Team Lead";
        job2._company = "Amazon";
        job2._startYear = 2023;
        job2._endYear = 2024;

        // Display the companies
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // Display the jobs using display method
        // job1.Display();
        // job2.Display();

        // Create resume instance
        Resume myResume = new Resume();
        myResume._personName = "Ebenezer John";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Verify we can access the first job title
        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        //Display the full resume
        myResume.Display();
    }
}