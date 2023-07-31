using Microsoft.Extensions.DependencyInjection;

public static class ServiceRegistration
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IToDoTaskRepository, TaskRepository>();
        services.AddTransient<IUsersRepository, UsersRepository>();
    }
}
