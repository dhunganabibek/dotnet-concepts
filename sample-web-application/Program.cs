using System.Net.Mime;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/", async (HttpContext content) =>
{

    StreamReader reader = new StreamReader(content.Request.Body);
    System.Console.WriteLine(await reader.ReadToEndAsync());
    return "Hello World";
});

app.Run();

