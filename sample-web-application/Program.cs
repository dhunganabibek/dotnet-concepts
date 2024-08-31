var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", (HttpContext content) =>
{
    System.Console.WriteLine("Hello World");
    return "Hello World";
});

app.Run();

