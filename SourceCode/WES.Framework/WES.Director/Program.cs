using WES.Director;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddWindowsService(options =>
{
    options.ServiceName = "WES Director";
});
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
