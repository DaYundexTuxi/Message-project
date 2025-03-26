using System.Transactions; // not sure how to use this 
using Message_project;


class Program
{
    static void Main(string[] args)
    {
        string[] enteredPhoneNumberArray = { };
        bool processOfEnteringNumbers = true; // bool for while loop: to input numbers in to the enteredPhoneNumberArray

        // creating MessageGenerator class object(dictionary) and filling it with information about themes
        MessageGenerator messageGenerator = new MessageGenerator();

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
                enteredPhoneNumberArray = enteredPhoneNumberArray.Concat(new string[] { inputedText }).ToArray();
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
        Console.Write(messageGenerator.writeThemesList());
        int enteredTheme = Convert.ToInt32(Console.ReadLine());

        //if asnwer yes - sends the message (rn only generates the message and gives it back as text)
        if (answerAboutSendingSMS == 'y')
        {
            foreach (string pn in enteredPhoneNumberArray)
            {
                PhoneNumber usedPhoneNumber = new PhoneNumber(pn);
                Console.WriteLine(PhoneNumber.sendTheMessage(enteredTheme));
            }
        }
        else
        {
            Console.WriteLine("ok-");
        }
    }
}