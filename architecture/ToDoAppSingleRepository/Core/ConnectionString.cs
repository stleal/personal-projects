using Microsoft.Extensions.Configuration;

public class ConnectionString
{

    private static string environment = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")) ?
    Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") : "Production";
    private static readonly IConfiguration configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true)
        .AddJsonFile($"appsettings.{environment}.json", optional: false)
        .Build();

    public static string GetDefaultConnectionString()
    {
        return configuration.GetConnectionString("DefaultConnection");
    }

}