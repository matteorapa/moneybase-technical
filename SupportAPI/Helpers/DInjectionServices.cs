using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SupportAPI.Interfaces;
using SupportAPI.Services;

namespace SupportAPI.Helpers;

public static class DInjectionServices
{
    public static void AddApiServices(this IServiceCollection services)
    {
        services.AddScoped<IChatService, ChatService>();
        
            
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new AutoMapperProfile());
        });

        var mapper = config.CreateMapper();
        services.AddSingleton(mapper);
    }
    
    public static IServiceCollection AddPersistence(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionStringDb = configuration["ConnectionString"];
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionStringDb)
                .EnableDetailedErrors(), ServiceLifetime.Transient);

        return services;
    }
}