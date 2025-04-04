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

        ServiceCollection? serviceCollection = new ServiceCollection();

        serviceCollection.AddScoped<IMessage, MessageGenerator>();
        serviceCollection.AddScoped<ILogger, FileLogger>();
        serviceCollection.AddScoped<IPhoneNumbersManager, PhoneNumbersManager>();
        serviceCollection.AddScoped<BusinessLogicTest>();

        ServiceProvider? serviceProvider = serviceCollection.BuildServiceProvider();

        BusinessLogicTest? handler = serviceProvider.GetService<BusinessLogicTest>();

        handler.startActualProgram();
        //handler.test();
    }
}