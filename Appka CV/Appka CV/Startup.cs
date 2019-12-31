using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Appka_CV.Models;
using Microsoft.EntityFrameworkCore;

namespace Appka_CV
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(AzureADB2CDefaults.AuthenticationScheme)
                .AddAzureADB2C(options => Configuration.Bind("AzureAdB2C", options));
            services.AddAuthorization(options =>
            {
                options.AddPolicy("HROnly", policy => policy.RequireClaim("extension_IsHR", "true"));
                options.AddPolicy("AdminOnly", policy => policy.RequireClaim("extension_IsAdmin", "true"));
            });


            services.AddCors(options =>
            {
                options.AddPolicy("myAllow",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration["DatabaseConnectionString"]));
            services.AddTransient<EFCompaniesRepository>();
            services.AddTransient<EFJobOffersRepository>();
            services.AddTransient<EFApplicationsRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseCors("myAllow");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMvc(route =>
            {
                route.MapRoute("", "{controller=JobOffer}/{action=Index}/{id?}");
            });
        }
    }
}
