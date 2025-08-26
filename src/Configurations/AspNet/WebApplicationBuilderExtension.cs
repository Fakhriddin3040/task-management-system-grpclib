using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.GrpcLib.AuthService.Services;


namespace TaskManagementSystem.GrpcLib.Configurations.AspNet;


public static class WebApplicationBuilderExtension
{

    public static void AddGrpcLibServices(this IServiceCollection services)
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

    public static void UseGrpcLibTaskBoardServices(this WebApplication app)
    {
        app.MapGrpcService<TaskBoardService.Services.TaskBoardService.TaskBoardServiceBase>();
    }
}
