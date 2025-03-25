using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Message_project
{
    class MessageGenerator // class only for generating messages as text to send them
    {
        // construction parts for the messages 
        // 
        string[] themesArray = { "Birthday", "InternationalWomensDay", "NewYear" };

        // arrays of simple greetings 
        string[] formalGreetingsArray = { "Hello", "Good day", "" }; // 
        string[] informalGreetingsArray = { "Heya", "What\'s up?", "Hi" };

        string messageText;
        Random random = new();

        // possible for using the constructor, but there's a problem with calling methods
        /*
        public MessageConstructor()
        {
            
        }
        */

        public string generateMessageText(string theme) //!!!!!!!!!!!!!!!!
        {
            switch (theme)
            {
                case "Birthday":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, I wish you hapiness and growing income!\n Best regards, your dear friend!!";
                    break;
                case "InternationalWomansDay":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, have a lovely day and \n Best regards, your dear friend!!";
                    break;
                case "NewYear":
                    messageText = $"{formalGreetingsArray[random.NextInt64(0, formalGreetingsArray.Length)]}, I wish you hapiness and growing income!\n Best regards, your dear friend!!";
                    break; 
            }
            return messageText;
        }
    }
}