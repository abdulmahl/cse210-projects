using System;
using static System.Console;
using System.IO;

//  The PromptGenerator generates and displays random prompts from 
//  a list of strings.
//  Creates a text file and writes to it using the StreamWriter function.
//  Allows the Journal program to be loaded from the created text file. 
public class PromptGenerator
    {
    public static String GetPrompt()
        {
            string[] _prompt = new []
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
            
            Random random = new Random();
            int indx = random.Next(_prompt.Length);

            return _prompt[indx];   
        }
        
        public void SaveToFile(List<Entry> entries)
        {
            WriteLine("What is the file name? ");
            string filename = ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    Entry entry = entries[i];
                    string line = $"Date: {entry.GetDate()}";
                    // string line1 = $"Time: {entry.getTime()}";
                    string line2 = $"Prompt: {entry.GetPrompt()}";
                    string line3 = $"Entry: {entry.GetResponse()}\n";
                    outputFile.WriteLine(line);
                    // outputFile.WriteLine(line1);
                    outputFile.WriteLine(line2);
                    outputFile.WriteLine(line3);
                    
                }
            }
        }

        public List<Entry> loadFile()
        {
            WriteLine("What is the file name? ");
            string fileName = ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<Entry> newList = new List<Entry>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(" ");

                Entry entry = new Entry();
    
                string line1 = entry.GetDate();
                string line2 = entry.GetPrompt();
                string line3 = entry.GetResponse();
                // newList.Add(entry);


                for (int i = 0; i < line.Length; i += 3)
                {
                    entry.SetDate(lines[0]);
                    entry.SetPrompt(lines[1]);
                    entry.SetResponse(lines[2]);
                }
            }

        return newList;
        }

    }