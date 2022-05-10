// See https://aka.ms/new-console-template for more information
using FirstDemo.ServerSide;
using Grpc.Net.Client;

Console.WriteLine("Hello, World!");

GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7056");
Greeter.GreeterClient client = new Greeter.GreeterClient(channel);

HelloReply? response = await client.SayHelloAsync(new HelloRequest { Name = "Simona" });
Console.WriteLine(response.Message);

