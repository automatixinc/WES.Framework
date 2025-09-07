using WES.Sortation;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddWindowsService(options =>
{
    options.ServiceName = "WES Sortation";
});
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
