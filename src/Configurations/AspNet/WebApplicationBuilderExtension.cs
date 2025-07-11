using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.GrpcLib.AuthService.Services;


namespace TaskManagementSystem.GrpcLib.Configurations.AspNet;


public static class WebApplicationBuilderExtension
{

    public static void AddGrpcLib(this IServiceCollection services)
    {
        services.AddGrpc();
        services.AddGrpcReflection();
    }

    public static void UseGrpcLib(this WebApplication app)
    {
        app.MapGrpcReflectionService();
    }


    public static void UseGrpcLibAuthServices(this WebApplication app)
    {
        app.MapGrpcService<UserService.UserServiceBase>();
    }
}
