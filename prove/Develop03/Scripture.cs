using System;
using static System.Console;

public class Scripture
    {        
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

            // The for loop contains the initializer, the conditition
            // and the iterator.
            for (int i = 0; i < _words.Count; i++)
            {
                int randomText = random.Next(_words.Count);
                if (randomText < 23)
                {
                    _words[i] = new string('_', _words[i].Length);
                    hiddenText = string.Join(' ', _words);
                }
            }
            
            WriteLine($"\n{book} {chapter}:{verseIndex1} {hiddenText}");
        }

        public void IsHidden()
        {
            showBookData.SetBook("Jacob");
            string book = showBookData.GetBook();
            showBookData.SetChapter(3);
            int chapter = showBookData.GetChapter();
            showBookData.SetVerseStart(11);
            int verseIndex = showBookData.GetVerseStart();

            _words = hiddenText.Split().ToList();
            Random random = new Random();

            for (int i = 0; i < _words.Count; i++)
            {
                if (random.NextDouble() < 1.1)
                {
                    _words[i] = new string('_', _words[i].Length);
                }

            }
            hiddenText = string.Join(' ', _words);
            WriteLine($"\n{book} {chapter}:{verseIndex} {hiddenText}"); 
        }  
    }