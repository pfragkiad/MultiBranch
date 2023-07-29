using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MultiBranch;

internal class Program
{
    static void Main(string[] args)
    {
        var app = Host.CreateDefaultBuilder().Build();

        Console.WriteLine(BCommon.Test);

        var config = app.Services.GetRequiredService<IConfiguration>();
        Console.WriteLine(config.GetValue<int>("Test"));

        Console.WriteLine(BSecondary.Test2);

    }
}