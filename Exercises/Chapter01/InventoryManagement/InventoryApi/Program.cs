
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

Console.WriteLine($"Application: {app.Environment.ApplicationName}");

Console.WriteLine($"Environment: {app.Environment.EnvironmentName}");

Console.WriteLine($"Content Root: {app.Environment.ContentRootPath}");

if (app.Environment.IsDevelopment())
{
    Console.WriteLine("Running in Development.");
}
else if (app.Environment.IsStaging())
{
    Console.WriteLine("Running in Staging.");
}
else if (app.Environment.IsProduction())
{
    Console.WriteLine("Running in Production.");
}
else
{
    Console.WriteLine("Running in a custom environment.");
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
