var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Dockerized Minimal API!");

app.Run("http://0.0.0.0:80");
