using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheraLang.BLL.Infrastructure.AzureConnectionFactory;
using System.Text;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL;
using TheraLang.DAL.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

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
        public static IServiceCollection AddAzureStorageClientFactory(this IServiceCollection services, string connectionString)
        {
            return services.AddTransient<IAzureConnectionFactory, AzureConnectionFactory.AzureConnectionFactory>(serviceProvider =>
                new AzureConnectionFactory.AzureConnectionFactory(connectionString));
        }
        public static IServiceCollection AddAuthentication(this IServiceCollection services,
            IConfiguration Configuration)
        {
            services.AddAuthorization((Action<AuthorizationOptions>)(o =>
           {
               o.AddPolicy("PiranhaRoles", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaRoles", "PiranhaRoles");
               }));
               o.AddPolicy("PiranhaRolesAdd", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaRoles", "PiranhaRoles");
                   policy.RequireClaim("PiranhaRolesAdd", "PiranhaRolesAdd");
               }));
               o.AddPolicy("PiranhaRolesDelete", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaRoles", "PiranhaRoles");
                   policy.RequireClaim("PiranhaRolesDelete", "PiranhaRolesDelete");
               }));
               o.AddPolicy("PiranhaRolesEdit", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaRoles", "PiranhaRoles");
                   policy.RequireClaim("PiranhaRolesEdit", "PiranhaRolesEdit");
               }));
               o.AddPolicy("PiranhaRolesSave", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaRoles", "PiranhaRoles");
                   policy.RequireClaim("PiranhaRolesSave", "PiranhaRolesSave");
               }));
               o.AddPolicy("PiranhaUsers", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaUsers", "PiranhaUsers");
               }));
               o.AddPolicy("PiranhaUsersAdd", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaUsers", "PiranhaUsers");
                   policy.RequireClaim("PiranhaUsersAdd", "PiranhaUsersAdd");
               }));
               o.AddPolicy("PiranhaUsersDelete", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaUsers", "PiranhaUsers");
                   policy.RequireClaim("PiranhaUsersDelete", "PiranhaUsersDelete");
               }));
               o.AddPolicy("PiranhaUsersEdit", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaUsers", "PiranhaUsers");
                   policy.RequireClaim("PiranhaUsersEdit", "PiranhaUsersEdit");
               }));
               o.AddPolicy("PiranhaUsersSave", (Action<AuthorizationPolicyBuilder>)(policy =>
               {
                   policy.RequireClaim("PiranhaAdmin", "PiranhaAdmin");
                   policy.RequireClaim("PiranhaUsers", "PiranhaUsers");
                   policy.RequireClaim("PiranhaUsersSave", "PiranhaUsersSave");
               }));
           }));
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