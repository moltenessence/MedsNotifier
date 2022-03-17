using MedsNotifier.Data;
using MedsNotifier.Data.DataAccess;
using MedsNotifier.Data.Models;
using MedsNotifier.JwtOptions;
using MedsNotifier.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("mongodb.json");
            MongoDbConfiguration = builder.Build();

        }
        public IConfiguration MongoDbConfiguration { get; set; }
        private JwtOptions.TokenOptions tokenOptions { get; } = new JwtOptions.TokenOptions();
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MongoDbSettings>(MongoDbConfiguration.GetSection("MongoDbSettings"));

            services.AddSingleton<IMongoDbSettings>(serviceProvider =>
                serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<MongoRepository>();
            services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
            services.AddScoped<AccountService>();
            services.AddSingleton<ITokenOptions, JwtOptions.TokenOptions>();
            services.AddScoped<IdentityService>();
            services.AddScoped<JWTService>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters= tokenOptions.TokenValidationParameters;
                options.SaveToken = true;
            });
            services.AddAuthorization();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseExceptionHandler("/Error");

            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
