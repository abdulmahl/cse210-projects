using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._companyName = "Microsoft";
        job1._yearStart = 2009;
        job1._yearEnd = 2013;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._yearStart = 2015;
        job2._yearEnd = 2022;

        Resume resume = new Resume();
        resume._personName = "M Abdul Mahl";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.ShowResume();
        // job1.showJob();
    }
}