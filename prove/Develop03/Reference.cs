using System;

public class Reference
    {
        // Private strings used in this class.
        private string _verseText;
        private string _endVerseText;
        private int _verseStart;
        private int _verseEnd;
        private string _book;
        private int _chapter;
        
        // Constructor for my Reference class. 
        public Reference()
        {
            _verseText = "O my brethren, hearken unto my words; arouse the faculties of your souls; shake yourselves that ye may awake from the slumber of death; and loose yourselves from the pains of hell that ye may not become angels to the devil, to be cast into that lake of fire and brimstone which is the second death.";
            _endVerseText = "";
            _book = "";
            _chapter = 0;
        }

        // Rendered text to be instantiated to any other part of my program.
        public string GetRenderedText()
        {
            string verse1 = _verseText;
            string verse2 = _endVerseText;
            return verse1 + verse2;
        }

        // Getter for _book variable.    
        public string GetBook()
        {
            return _book;
        }

        // Setter for my _book variable
        public void SetBook(string book)
        {
            _book = book;
        }

        // Getter for _chapter variable.    
        public int GetChapter()
        {
            return _chapter;
        }

        // Setter for my _chapter variable
        public void SetChapter(int chapter)
        {
            _chapter = chapter;
        }

        // Getter for _verseStart variable.    
        public int GetVerseStart()
        {
            return _verseStart;
        }

        // Setter for my _verseStart variable
        public void SetVerseStart(int verse)
        {
            _verseStart = verse;
        }

        // Getter for _verseEnd variable.    
        public int GetVerseEnd()
        {
            return _verseEnd;
        }

        // Setter for my _verseEnd variable
        public void SetVerseEnd(int verse)
        {
            _verseEnd = verse;
        }

    }