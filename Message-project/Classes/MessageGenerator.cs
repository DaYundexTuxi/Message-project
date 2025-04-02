using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Message_project.Interfaces;
using NLog;


namespace Message_project.Classes
{
    // class only for generating messages as text to send them
    internal class MessageGenerator : IMessage
    {
        // getting logger 
        //private readonly ILogger fileLogger = new NLog.LogManager.();

        // construction parts for the messages 
        // set of themes
        static Dictionary<int, string> themesDictionary = new()
        {
            { 1, "Birthday" },
            { 2, "InternationalWomensDay" },
            { 3, "NewYear" }
        };

        // arrays of simple greetings 
        string[] formalGreetingsArray = { "Hello", "Good day", "" }; // 
        string[] informalGreetingsArray = { "Heya", "What\'s up?", "Hi" };

        // jus t
        static string themesString;
        public string messageText;
        Random random = new();

        public string getThemesList()
        {
            for (int i = 0; i < themesDictionary.Count; i++)
            {
                try
                {
                    themesString += $"{i + 1}. {themesDictionary[i + 1]} ";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    //fileLogger.Log($"{e.ToString()}");
                }
            }
            // log the desired message about the operation
            return themesString.Trim(); 
        }
        //public int getThemesCount() { return themesDictionary.Count; }

        //  generating a message depending on needed theme (using random )
        public string getGeneratedMessageText(int themeId) 
        {
            string theme = themesDictionary[themeId];
            switch (theme)
            {
                case "Birthday":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, I wish you hapiness and growing income!\n Best regards, your dear friend!!";
                    break;
                case "InternationalWomensDay":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, have a lovely day and \n Best regards, your dear friend!!";
                    break;
                case "NewYear":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, I wish you happy new year!\n Best regards, your dear friend!!";
                    break;
            }
            //fileLogger.Log(messageText);
            return messageText;
        }
    }
}