var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseWelcomePage();
app.Run();
/*
 await app.StartAsync();
 await Task.Delay(10000);
 await app.StopAsync();
*/

