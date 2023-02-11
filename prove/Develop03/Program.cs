using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference();
        Scripture script = new Scripture();
        Scripture script1 = new Scripture();
        Word word = new Word();

        ref1.SetBook("Jacob");
        string book = ref1.GetBook();
        ref1.SetChapter(3);
        int chapter = ref1.GetChapter();
        ref1.SetVerseStart(11);
        // ref1.SetVerseEnd(12);
        int verseIndex1 = ref1.GetVerseStart();
        // int verseIndex2 = ref1.GetVerseEnd();

        string verse = word.GetRenderedText();
        
        string key = "";
        Clear();
        WriteLine($"\n{book} {chapter}:{verseIndex1} {verse}");

        while (key != "quit")
        {
            Write("\nPress enter to continue or type 'quit' to finish: ");
            key = ReadLine();
            Clear();

            if (key == "quit")
            {
                return;
            }
        
            word.HideWord();
        
            // if (word.CompletelyHidden())
            // {
            //     return;
            // }
        }
    }  
}