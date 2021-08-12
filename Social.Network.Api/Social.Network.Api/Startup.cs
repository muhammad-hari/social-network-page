using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Social.Network.Application.Services;
using Social.Network.Data.Contexts;
using Social.Network.Data.Repository.Commands;
using Social.Network.Data.Repository.Queries;
using Social.Network.Data.Seeds;
using Social.Network.Domain.Commands;
using Social.Network.Domain.Models.Auths;
using Social.Network.Domain.Queries;
using Social.Network.Domain.Seeds;
using Social.Network.Domain.Services;
using System;
using System.Text;

namespace Social.Network.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Database Config
            services.AddDbContext<SocialNetworkContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DEV")));

            // configure strongly typed settings object
            services.Configure<OAuthIdentity>(Configuration.GetSection("OAuthIdentity"));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Social Network API",
                    Description = "Social Network API",
                    TermsOfService = new Uri(@"https://www.linkedin.com/in/muhammad-hari/"),
                    Contact = new OpenApiContact
                    {
                        Name = "Hari",
                        Email = "muhammadhari018@gmail.com",
                        Url = new Uri(@"https://www.linkedin.com/in/muhammad-hari/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri(@"https://www.linkedin.com/in/muhammad-hari/"),
                    }
                });

            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = true;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["OAuthIdentity:Secret"])),
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(1.0)
                };

            });


            // Repository
            services.AddTransient<IQueryRepository, QueryRepository>();
            services.AddTransient<ICommandRepository, CommandRepository>();

            // Services
            services.AddScoped<IUserService, UserService>();

            // Data Seeds
            services.AddSingleton<IDataSeeds, DataSeeds>();

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Social Network API");
                c.DocumentTitle = "Social Network API";
                c.RoutePrefix = string.Empty;
            });


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
