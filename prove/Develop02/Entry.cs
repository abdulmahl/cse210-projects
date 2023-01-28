using System;
using static System.Console;

// The Entry class sets and gets the date,
// sets and gets the response.
public class Entry
   {
        private string _date;
        // private string _time;
        private string _prompt;
        private string _response;

        public void setDate(string date)
        {
            _date = date;
        }

        // public void setTime(string time)
        // {
        //     _time = time;
        // }

        // public string getTime()
        // {
        //     return _time;
        // }
        
        public string getDate()
        {
            
            return _date;
        }

        public void setPrompt(string prompt)
        {
            _prompt = prompt;
        }

        public string getPrompt()
        {
            return _prompt;
        }

        public void setResponse(string response)
        {
            _response = response;
        }

        public string getResponse()
        {
            
            return _response;
        }
   }