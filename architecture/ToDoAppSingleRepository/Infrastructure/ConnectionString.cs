using Microsoft.Extensions.Configuration;

internal class ConnectionString
{

    private static string environment = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIORNMENT")) ?
    Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") : "Development";
    private static readonly IConfiguration configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true)
        .AddJsonFile($"appsettings.{environment}.json", optional: false)
        .Build();

    public static string GetDefaultConnectionString()
    {
        return configuration.GetConnectionString("DefaultConnection");
    }

}