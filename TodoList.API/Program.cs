internal class Program
{
  private static void Main(string[] args)
  {
    // Step 1 get a builder
    // ASP .NET Core uses the Builder Pattern
    // For constructing the web server/application
    var webAppBuilder = WebApplication.CreateBuilder(args);

    // Step 2 Configure the application
    // Configure the builder

    // Step 3 Build
    var app = webAppBuilder.Build();

    // Step 4 Last mile configuration
    app.MapGet("/", () => "Hello World!");
    app.MapGet("/todoes", () => "foo");
    app.MapGet("/todoes/testing", () => "bar");
    app.MapGet("/api/v1/todolist", () => "buz");

    // Step 5 Star the application
    app.Run();
  }
}


