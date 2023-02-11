using System;
using static System.Console;

public class Scripture
    {

        // I instantiated my Reference class to display the verse text,
        // into my Scripture class, my Scripture class is responsible for 
        // hiding random verse text, whether it hides some text or hides
        // all the text from the verse.
        
        Reference _textWord = new Reference();
        Reference showBookData = new Reference();
        string hiddenText = "";


        List<string> _words = new List<string>();
        public Scripture()
        {
            hiddenText = _textWord.GetRenderedText();
        }
        
        public void Hide()
        {

            showBookData.SetBook("Jacob");
            string book = showBookData.GetBook();
            showBookData.SetChapter(3);
            int chapter = showBookData.GetChapter();
            showBookData.SetVerseStart(11);
            int verseIndex1 = showBookData.GetVerseStart();

            _words = hiddenText.Split().ToList();
            Random random = new Random();

            string key = "";

            for (int i = 0; i < _words.Count; i++)
            {
                if (random.NextDouble() > .6)
                {
                    _words[i] = new string('_', _words[i].Length);
                    hiddenText = string.Join(' ', _words);

                }
            }

            if (key == "quit")
            {
                return;
            }

            WriteLine($"\n{book} {chapter}:{verseIndex1} {hiddenText}");
        }

        // public void IsHidden()
        // {
        //     showBookData.SetBook("Jacob");
        //     string book = showBookData.GetBook();
        //     showBookData.SetChapter(3);
        //     int chapter = showBookData.GetChapter();
        //     showBookData.SetVerseStart(11);
        //     int verseIndex = showBookData.GetVerseStart();

        //     string text = _textWord.GetRenderedText();
        //     string[] _words = text.Split();
        //     Random random = new Random();

        //     for (int i = 0; i < _words.Length; i++)
        //     {
        //         if (random.NextDouble() < 1.1)
        //         {
        //             _words[i] = new string('_', _words[i].Length);
        //         }
        //     }
        //     string hiddenText = string.Join(' ', _words);
        //     WriteLine($"\n{book} {chapter}:{verseIndex} {hiddenText}"); 
        // }  
    }