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

        public void SetDate(string date)
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
        
        public string GetDate()
        {
            
            return _date;
        }

        public void SetPrompt(string prompt)
        {
            _prompt = prompt;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public void SetResponse(string response)
        {
            _response = response;
        }

        public string GetResponse()
        {
            
            return _response;
        }
   }