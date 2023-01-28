using System;
using static System.Console;

public class Job
    {
        public string _jobTitle;
        public string _companyName;
        public int _yearStart;
        public int _yearEnd;
        public string _currentYear;

        public void showJob()
        {
            WriteLine($"{_jobTitle} ({_companyName}), {_yearStart} - {_yearEnd}"); 
        }

    }