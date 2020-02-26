using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Infrastructure.AzureConnectionFactory;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services.File;
using TheraLang.DAL;
using TheraLang.DAL.UnitOfWork;
using Common.Configurations;

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
        
        public static IServiceCollection AddFileStorage(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                return services.AddTransient<IFileService, LocalFileService>();
            }
            services.AddTransient<IAzureConnectionFactory, AzureConnectionFactory.AzureConnectionFactory>(serviceProvider =>
                new AzureConnectionFactory.AzureConnectionFactory(connectionString));
            return services.AddTransient<IFileService, AzureFileService>();
        }
        
        public static IServiceCollection AddAuthentication(this IServiceCollection services,
            IConfiguration Configuration)
        {
            services.Configure<TokenManagement>(Configuration.GetSection("tokenManagement"));
            var token = Configuration.GetSection("tokenManagement").Get<TokenManagement>();
            var secret = Encoding.ASCII.GetBytes(token.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secret),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            return services;
        }
    }
}