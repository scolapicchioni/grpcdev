using ClientFactoryIntegration.ServerSide;
using Microsoft.Extensions.Hosting;

namespace ClientFactoryIntegration.ConsoleClient.Services;
internal class MyClass : IHostedService {
    private readonly Greeter.GreeterClient client;

    public MyClass(Greeter.GreeterClient client) {
        this.client = client;
    }
    public async Task StartAsync(CancellationToken cancellationToken) {
        Console.WriteLine((await client.SayHelloAsync(new HelloRequest() { Name = "Simona" })).Message);
    }

    public Task StopAsync(CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}
