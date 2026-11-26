Console.WriteLine("STEP 1: Application entry point reached.");

WebApplicationBuilder builder =
    WebApplication.CreateBuilder(args);

Console.WriteLine("STEP 2: WebApplicationBuilder created.");

//builder.Services.AddControllers();
builder.Services.AddAuthorization();

//Console.WriteLine("STEP 3: Controller services registered.");

WebApplication app = builder.Build();

Console.WriteLine("STEP 4: WebApplication constructed.");

Console.WriteLine($"Application: {app.Environment.ApplicationName}");
Console.WriteLine($"Environment: {app.Environment.EnvironmentName}");

app.UseHttpsRedirection();

Console.WriteLine("STEP 5: HTTPS redirection configured.");

app.UseAuthorization();

Console.WriteLine("STEP 6: Authorization configured.");

app.MapControllers();

Console.WriteLine("STEP 7: Controller endpoints mapped.");

Console.WriteLine("STEP 8: Starting application.");

app.Run();

Console.WriteLine("STEP 9: Application stopped.");