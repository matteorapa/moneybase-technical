using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SupportAPI.DAL;
using SupportAPI.Interfaces;
using SupportAPI.Services;

namespace SupportAPI.Helpers;

public static class DInjectionServices
{
    public static void AddApiServices(this IServiceCollection services)
    {
        services.AddScoped<IChatService, ChatService>();
        services.AddScoped<ITeamService, TeamService>();
        services.AddScoped<IMessageService, MessageService>();
        services.AddScoped<IChatRepository, ChatRepository>();
        services.AddScoped<ITeamRepository, TeamRepository>();
        services.AddScoped<IMessageRepository, MessageRepository>();
        services.AddScoped<IQueueProducer, QueueProducerService>();
        services.AddScoped<IQueueConsumer, QueueConsumerService>();
        
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
                .EnableDetailedErrors(), ServiceLifetime.Singleton);
        
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        return services;
    }
}