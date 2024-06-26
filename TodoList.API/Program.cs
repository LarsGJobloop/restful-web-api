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
    // Uses Dependency Injection for registering services
    webAppBuilder.Services.AddControllers(); // This allows us to use controllers
    // There is only one instance of a singleton
    webAppBuilder.Services.AddSingleton<ITodoListService>(new TodoListInMemoryService());

    // Creates a new instance for each request
    // webAppBuilder.Services.AddScoped<ITodoListService, TodoListInMemoryService>();

    // Creates a new instance each time its invoked/called
    // webAppBuilder.Services.AddTransient<ITodoListService, TodoListInMemoryService>();

    // Step 3 Build
    var app = webAppBuilder.Build();

    // Step 4 Last mile configuration
    app.MapGet("/", () => "Hello World!");

    app.MapControllers(); // This mounts(maps/binds) the controllers to specifc routes

    // Step 5 Star the application
    app.Run();
  }
}
