using System;
using static System.Console;

//  The Journal class holds a list of entered input.
//  Gets random prompt from the PromptGenerator class, gets the current date
//  to display on the console, voids a list of entries, displays the current date
//  the random prompt and the entry to the console and then returns those
//  entries.
public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        public void AddEntry()
        {
            string _prompt = PromptGenerator.getPrompt();
            WriteLine(_prompt);
            Write("> ");
            string _response = ReadLine();

            DateTime currentDate = DateTime.Now;
            string _date = currentDate.ToShortDateString();

            // DateTime currentTime = DateTime.Now;
            // string _time = currentTime.ToShortTimeString();

            Entry entry = new Entry();
            entry.setDate(_date);
            entry.setPrompt(_prompt);
            entry.setResponse(_response);
            // entry.setTime(_time);
            _entries.Add(entry);
        }

        public void setEntries(List<Entry> entries)
        {
            _entries = entries;
        }

        public void DisplayEntry()
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                Entry entry = _entries[i];
                WriteLine($"\nDate: {entry.getDate()} - Prompt: {entry.getPrompt()}");
                WriteLine($"{entry.getResponse()}");
            }
        }
        
        public List<Entry> GetEntries()
        {
            return _entries;
        }
    }