using System.Transactions; // not sure how to use this 
//using
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleDI.Example;
using Message_project.interfaces;
using Message_project.Classes;

// ADD FOLDERS - interfaces \ classes \ etc.
// LOGS!!!!!!!! + dependency inj nlog lib
// 

class Program
{

    static void Main(string[] args)
    {
        ServiceCollection? serviceCollection = new ServiceCollection();

        serviceCollection.AddScoped<IMessage, MessageGenerator>();
        serviceCollection.AddScoped<ILogger, FileLogger>();
        serviceCollection.AddScoped<ConsoleBusinessLogicTest>();

        ServiceProvider? serviceProvider = serviceCollection.BuildServiceProvider();

        ConsoleBusinessLogicTest? handler = serviceProvider.GetService<ConsoleBusinessLogicTest>();

        handler.test();
    }
}