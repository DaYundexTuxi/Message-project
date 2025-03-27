using System.Transactions; // not sure how to use this 
using Message_project;

// LOGS!!!!!!!! + dependency inj nlog lib
class Program
{

    static void Main(string[] args)
    {
        string[] enteredPhoneNumberArray = { };
        bool processOfEnteringNumbers = true; // bool for while loop: to input numbers in to the enteredPhoneNumberArray

        // logger thingys
        ILogger fileLogger = new FileLogger();

        // creating MessageGenerator class object(dictionary) and filling it with information about themes
        // got rid of it

        // start of the program
        Console.WriteLine("Enter the desired phone numbers: ");
        Console.WriteLine("You can enter \'exit\' to exit the entering the numbers");

        // loop for filling the array with phone numbers
        while (processOfEnteringNumbers)
        {
            string inputedText = Console.ReadLine();

            if (inputedText == "exit")
            {
                break;
            }
            else if (PhoneNumber.isValid(inputedText))
            {
                enteredPhoneNumberArray = enteredPhoneNumberArray.Concat(new string[] { inputedText }).ToArray(); // creates a new array and adds to it 
                fileLogger.Log("");
            }
            else
            {
                Console.WriteLine("Invalid number entered, try again.");
            }
        }

        // showing the list of entered phone numbers
        foreach (string pNumber in enteredPhoneNumberArray)
        {
            Console.WriteLine($"{pNumber} is in the list.");
        }

        //asking for sending email 
        Console.Write($"You have entered {enteredPhoneNumberArray.Length} phone numbers, do you want to send them an sms?(y/n): ");
        char answerAboutSendingSMS = Convert.ToChar(Console.ReadLine());
         
        //asking for the theme of a message 
        Console.Write($"You can choose the theme from this list(write the number of theme):");
        // printing out the list of themes

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 56 line
        MessageGenerator.writeThemesList(); // ask if is it better, writing information right in method or giving it back as string for main to output it (purpose - write list of themes)
        int enteredTheme = Convert.ToInt32(Console.ReadLine());

        //if asnwer yes - sends the message (rn only generates the message and gives it back as text)
        if (answerAboutSendingSMS == 'y')
        {
            foreach (string individualPhoneNumber in enteredPhoneNumberArray)
            {
                PhoneNumber usedPhoneNumber = new PhoneNumber(individualPhoneNumber);
                Console.WriteLine(PhoneNumber.sendTheMessage(enteredTheme)); 
            }
        }
        else
        {
            Console.WriteLine("ok-");
        }
    }
}