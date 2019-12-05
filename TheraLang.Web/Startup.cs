using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Piranha;
using Piranha.AspNetCore.Identity.SQLServer;
using TheraLang.DLL;
using TheraLang.DLL.Services;
using TheraLang.DLL.UnitOfWork;
using TheraLang.Web.Helpers;
using TheraLang.Web.Services;

namespace TheraLang.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="configuration">The current configuration</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalization(options =>
                options.ResourcesPath = "Resources"
            );

            services.AddMvc()
                .AddPiranhaManagerOptions()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(fv => { fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false; });

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
            services.AddPiranhaIdentityWithSeed<IdentitySQLServerDb>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMemoryCache();
            services.AddPiranhaMemoryCache();
            #endregion

            #region register services via IServiceCollection

            services.AddDbContext<IttmmDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IUnitOfWork, UnitOfWork>(provider =>
               new UnitOfWork(provider.GetRequiredService<IttmmDbContext>()));
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IProjectTypeService, ProjectTypeService>();
            services.AddCors(options =>
                options.AddPolicy("development mode", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())); //TODO: remove after app integrated
            services.AddTransient<IResourceService, ResourceService>();
            services.AddTransient<IResourceCategoryService, ResourceCategoryService>();
            services.AddTransient<IProjectParticipationService, ProjectParticipationService>();
            services.AddTransient<IDonationService, DonationService>();
            services.AddOpenApiDocument();
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
            App.CacheLevel = Piranha.Cache.CacheLevel.Full;

            // Build content types
            var pageTypeBuilder = new Piranha.AttributeBuilder.PageTypeBuilder(api)
                .AddType(typeof(Models.BlogArchive))
                .AddType(typeof(Models.StandardPage))
                .AddType(typeof(Models.TeaserPage))
                .Build()
                .DeleteOrphans();
            var postTypeBuilder = new Piranha.AttributeBuilder.PostTypeBuilder(api)
                .AddType(typeof(Models.BlogPost))
                .Build()
                .DeleteOrphans();
            var siteTypeBuilder = new Piranha.AttributeBuilder.SiteTypeBuilder(api)
                .AddType(typeof(Models.StandardSite))
                .Build()
                .DeleteOrphans();

            /**
             *
             * Test another culture in the UI
             *
            var cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
             */
            // Register middleware
            app.UseStaticFiles();
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

            //Seed.RunAsync(api).GetAwaiter().GetResult(); //TODO: fix seeding
        }
    }
}
