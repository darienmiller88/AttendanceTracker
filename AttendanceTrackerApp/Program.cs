using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.Use(async (context, next) =>
{
    Stopwatch stopwatch = new Stopwatch();

    stopwatch.Start();
    await next();
    stopwatch.Stop();

    Console.WriteLine($"request method {context.Request.Method} {stopwatch.ElapsedMilliseconds} ms");
});

app.UseStaticFiles();
app.MapRazorPages();

app.Run();