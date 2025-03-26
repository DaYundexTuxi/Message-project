using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Message_project
{
    internal class MessageGenerator // class only for generating messages as text to send them
    {
        // construction parts for the messages 
        // 
        Dictionary<int, string> themesDictionary = new()
        {
            { 1, "Birthday" },
            { 2, "InternationalWomensDay" },
            { 3, "NewYear" }
        };
        
        // arrays of simple greetings 
        string[] formalGreetingsArray = { "Hello", "Good day", "" }; // 
        string[] informalGreetingsArray = { "Heya", "What\'s up?", "Hi" };

        string themesString;
        string messageText;
        Random random = new();

        public string writeThemesList()
        {
            for (int i = 0; i < themesDictionary.Count; i++)
            {
                try
                {
                    themesString += $"{i + 1}. {themesDictionary[i+1]} ";
                } 
                catch (Exception e) 
                {
                    Console.WriteLine(e.ToString());
                }
                
            }
            return themesString.Trim();
        }


        //public int countThemes() { return themesDictionary.Count; }


        public string generateMessageText(int themeId) //!!!!!!!!!!!!!!!!
        {
            string theme = themesDictionary[themeId];
            switch (theme)
            {
                case "Birthday":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, I wish you hapiness and growing income!\n Best regards, your dear friend!!";
                    break;
                case "InternationalWomansDay":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, have a lovely day and \n Best regards, your dear friend!!";
                    break;
                case "NewYear":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, I wish you happy new year!\n Best regards, your dear friend!!";
                    break; 
            }
            return messageText;
        }
    }
}