using System;
using static System.Console;

public class Resume
    {
        public string _personName = "";

        public List<Job> _jobs = new List<Job>();
        public void ShowResume()
        {
            WriteLine(_personName);
            WriteLine("Jobs: ");
            foreach (Job job in _jobs)
            {
                job.showJob();
            }
        }
    }