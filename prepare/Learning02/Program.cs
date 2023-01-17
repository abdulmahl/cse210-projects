using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume resumeIns = new Resume();
        resumeIns._personName = "M. Abdul Mahl";

        resumeIns._jobs.Add(job1);
        resumeIns._jobs.Add(job2);

        resumeIns.Display();

    }

}