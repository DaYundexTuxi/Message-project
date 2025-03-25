using System.Transactions; // not sure how to use this 
using Message_project;


class Program
{
    static void Main(string[] args)
    {
        string[] enteredPhoneNumberArray = { };
        bool processOfEnteringNumbers = true; // bool for while loop: to input numbers in to the enteredPhoneNumberArray


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
                enteredPhoneNumberArray = new string[] { inputedText };
            }
            else
            {
                Console.WriteLine("Invalid number entered, try again.");
            }

            //switch (input)
            //{
            //    case "exit":
            //        enteringNumbers = false;
            //        break;
            //    case :
            //        Console.WriteLine("a");
            //    default: 
            //}
        }

        // showing the list of entered phone numbers
        foreach (string pNumber in enteredPhoneNumberArray)
        {
            Console.WriteLine($"{pNumber} is in the list.");
        }

        //asking for sending email + should be 
        Console.Write($"You have entered {enteredPhoneNumberArray.Length} phone numbers, do you want to send them an sms?(y/n): ");
        char answerAfterPNumbers = Convert.ToChar(Console.ReadLine());

        if (answerAfterPNumbers == 'y')
        {
            foreach (string pn in enteredPhoneNumberArray)
            {
                PhoneNumber usedPhoneNumber = new PhoneNumber(pn);
                usedPhoneNumber.;
            }
        }
        else
        {
            Console.WriteLine("ok-");
        }
    }
}