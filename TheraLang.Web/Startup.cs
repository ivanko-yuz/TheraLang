using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Piranha;
using Piranha.AspNetCore.Identity.SQLServer;
using TheraLang.BLL.Infrastructure;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.Web.Helpers;
using TheraLang.Web.Validators;
using TheraLang.Web.ViewModels;


namespace TheraLang.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddLocalization(options =>
            //    options.ResourcesPath = "Resources"
            //);

            //services.AddMvc()
            //    //.AddPiranhaManagerOptions()
            //    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
            //    .AddFluentValidation(fv => { fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false; });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddScoped<IAuthenticateService, TokenAuthenticationService>();
            services.AddScoped<IUserManagementService, UserManagementService>();
            
            #region Piranha setup
            services.AddPiranha();
            services.AddPiranhaApplication();
            services.AddPiranhaFileStorage();
            services.AddPiranhaImageSharp();
            services.AddPiranhaManager();
            services.AddPiranhaSummernote();
            //services.AddPiranhaTinyMCE();
            services.AddPiranhaApi();

            services.AddPiranhaEF(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMemoryCache();
            services.AddPiranhaMemoryCache();
            #endregion

            #region register services via IServiceCollection

            services.AddMainContext(Configuration.GetConnectionString("DefaultConnection"));
            services.AddUnitOfWork();
            services.AddAuthentication(Configuration);

            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IProjectTypeService, ProjectTypeService>();
            services.AddCors(options =>
                options.AddPolicy("development mode", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())); //TODO: remove after app integrated
            services.AddTransient<IResourceService, ResourceService>();
            services.AddTransient<IResourceCategoryService, ResourceCategoryService>();
            services.AddTransient<IProjectParticipationService, ProjectParticipationService>();
            services.AddTransient<IDonationService, DonationService>();
            services.AddTransient<IResourceAttachmentService, ResourceAttachmentService>();
            services.AddOpenApiDocument();
            services.AddTransient<IValidator<ResourceViewModel>, ResourceViewModelValidator>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApi api, ILoggerFactory loggerFactory)
        {
            app.ConfigureExceptionHandler(loggerFactory, env.IsDevelopment());
            if (env.IsDevelopment())
            {
                app.UseCors("development mode");
                app.UseDeveloperExceptionPage();
                app.UseOpenApi();
                app.UseSwaggerUi3();
            }


            App.Init(api);
            // Configure cache level
            App.CacheLevel = Piranha.Cache.CacheLevel.None;

            // Build content types
            //new Piranha.AttributeBuilder.PageTypeBuilder(api)
            //    .AddType(typeof(Models.BlogArchive))
            //    .AddType(typeof(Models.StandardPage))
            //    .AddType(typeof(Models.TeaserPage))
            //    .Build()
            //    .DeleteOrphans();
            //new Piranha.AttributeBuilder.PostTypeBuilder(api)
            //    .AddType(typeof(Models.BlogPost))
            //    .Build()
            //    .DeleteOrphans();
            //new Piranha.AttributeBuilder.SiteTypeBuilder(api)
            //    .AddType(typeof(Models.StandardSite))
            //    .Build()
            //    .DeleteOrphans();

            // Register middleware
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseAuthentication();
            app.UsePiranhaManager();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "areaRoute",
                    template: "{area:exists}/{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=home}/{action=index}/{id?}");

                routes.MapRoute(
                   name: "angular",
                   template: "{*template}",
                   defaults: new { controller = "Home", action = "Index" });
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });

            //Seed.RunAsync(api).GetAwaiter().GetResult(); //TODO: fix seeding
        }
    }
}
