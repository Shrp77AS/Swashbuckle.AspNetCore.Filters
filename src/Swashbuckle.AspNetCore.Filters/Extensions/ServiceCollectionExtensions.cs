using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Swashbuckle.AspNetCore.Filters.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSwaggerExamplesFromAssemblyOf<T>(this IServiceCollection services)
        {
            services.AddSingleton<SerializerSettingsDuplicator>();
            services.AddSingleton<JsonFormatter>();
            services.AddSingleton<RequestExample>();
            services.AddSingleton<ResponseExample>();
            services.AddSingleton<ExamplesOperationFilter>();
            services.AddSingleton<ServiceProviderExamplesOperationFilter>();

            services.Scan(scan => scan
                .FromAssemblyOf<T>()
                    .AddClasses(classes => classes.AssignableTo(typeof(IExamplesProvider<>)))
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .WithSingletonLifetime()
            );

            return services;
        }

        public static IServiceCollection AddSwaggerExamplesFromAssemblies(this IServiceCollection services,
            Assembly[] assemblies)
        {
            services.AddSingleton<SerializerSettingsDuplicator>();
            services.AddSingleton<JsonFormatter>();
            services.AddSingleton<RequestExample>();
            services.AddSingleton<ResponseExample>();
            services.AddSingleton<ExamplesOperationFilter>();
            services.AddSingleton<ServiceProviderExamplesOperationFilter>();

            services.Scan(scan => scan
                .FromAssemblies(assemblies)
                .AddClasses(classes => classes.AssignableTo(typeof(IExamplesProvider<>)))
                .AsImplementedInterfaces()
                .AsSelf()
                .WithSingletonLifetime()
            );

            return services;
        }
    }
}
