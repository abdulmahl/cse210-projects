using System;
using static System.Console;

public class Word
    {
       
        // Instantiator from my Reference class.
        Reference _reference = new Reference();

        // Instantiator from my Word class.
        Scripture _hideText = new Scripture();

        // Constructor for my Scripture class with no parameters.
        public Word()
        {
            
        }

        // Rendered text referenced from my Reference class
        // instanciated in my Program class.
        public string GetRenderedText()
        {
            string renderedText = _reference.GetRenderedText();
            return renderedText;
        }

        // Hide word method instanciated in my Program class
        //  referenced from my Scripture class.
        public bool HideWord()
        {
            _hideText.Hide();
            return true;
        }

        // Completely hide word method instanciated in my Program class
        //  referenced from my Scripture class.
        public bool CompletelyHidden()
        {
            // _hideText.IsHidden();
            return true;
        }
    }