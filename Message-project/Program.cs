using System.Transactions; // not sure how to use this 
using Message_project;
//using
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using ConsoleDI.Example;

// LOGS!!!!!!!! + dependency inj nlog lib
class Program
{

    static async void Main(string[] args)
    {

        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
        builder.Services.AddTransient<ServiceLifetimeReporter>();

        using IHost host = builder.Build();
        ExemplifyServiceLifetime(host.Services, "Lifetime 1");
        ExemplifyServiceLifetime(host.Services, "Lifetime 2");

        await host.RunAsync();

        static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
            logger.ReportServiceLifetimeDetails(
                $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            Console.WriteLine("...");

            logger = provider.GetRequiredService<ServiceLifetimeReporter>();
            logger.ReportServiceLifetimeDetails(
                $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            Console.WriteLine();
        }

        // ---------------------------------------------------------------------------------------------------------------------

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
            else if (PhoneNumbers.isValid(inputedText))
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

        Console.WriteLine(MessageGenerator.getThemesList()); 
        int enteredTheme = Convert.ToInt32(Console.ReadLine());

        //if asnwer yes - sends the message (rn only generates the message and gives it back as text)
        if (answerAboutSendingSMS == 'y')
        {
            foreach (string individualPhoneNumber in enteredPhoneNumberArray)
            {
                PhoneNumbers usedPhoneNumber = new PhoneNumbers(individualPhoneNumber);
                Console.WriteLine(PhoneNumbers.getTheMessage(enteredTheme)); 
            }
        }
        else
        {
            Console.WriteLine("ok-");
        }
    }
}