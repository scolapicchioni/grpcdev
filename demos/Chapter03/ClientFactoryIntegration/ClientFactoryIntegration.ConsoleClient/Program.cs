using ClientFactoryIntegration.ConsoleClient.Services;
using ClientFactoryIntegration.ServerSide;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();

await host.RunAsync();

IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) => {
                services.AddHostedService<MyClass>();
                services.AddGrpcClient<Greeter.GreeterClient>(o => {
                    o.Address = new Uri(hostContext.Configuration.GetSection("GrpcAddress").Value);
                });
            });