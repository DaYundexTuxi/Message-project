using System.Transactions; // not sure how to use this 
//using
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Message_project.Interfaces;
using Message_project.Classes;

// ADD FOLDERS - interfaces \ classes \ etc.
// LOGS!!!!!!!! + dependency inj nlog lib
// make a filemanager that will use data recieved via file (ejson)

class Program
{
    static void Main(string[] args)
    {
        //ConsoleBusinessLogicTest.startActualProgram();
        ServiceCollection? serviceCollection = new ServiceCollection();

        serviceCollection.AddScoped<IMessage, MessageGenerator>();
        serviceCollection.AddScoped<ILogger, FileLogger>();
        serviceCollection.AddScoped<IPhoneNumbersManager, PhoneNumbersManager>();
        serviceCollection.AddScoped<ConsoleBusinessLogicTest>();

        ServiceProvider? serviceProvider = serviceCollection.BuildServiceProvider();

        ConsoleBusinessLogicTest? handler = serviceProvider.GetService<ConsoleBusinessLogicTest>();

        //handler.startActualProgram();
        handler.test();
    }
}