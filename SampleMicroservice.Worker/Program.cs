using SampleMicroservice.Worker;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Logging.AddConsole();

var host = builder.Build();
host.Run();

