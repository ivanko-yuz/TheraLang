using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheraLang.BLL.Infrastructure.AzureConnectionFactory;
using TheraLang.DAL;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Infrastructure
{
    public static class BllServiceCollectionExtensions
    {
        public static IServiceCollection AddMainContext(this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<IttmmDbContext>(options => options.UseSqlServer(connectionString));
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services.AddTransient<IUnitOfWork, UnitOfWork>(provider =>
                new UnitOfWork(provider.GetRequiredService<IttmmDbContext>()));
        }
        public static IServiceCollection AddAzureStorageClientFactory(this IServiceCollection services,string connectionString)
        {
            return services.AddTransient<IAzureConnectionFactory, AzureConnectionFactory.AzureConnectionFactory>(serviceProvider =>
                new AzureConnectionFactory.AzureConnectionFactory(connectionString));
        }
    }
}
