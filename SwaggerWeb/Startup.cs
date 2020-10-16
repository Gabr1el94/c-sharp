using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SwaggerWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace SwaggerWeb
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
            // configuration initialized db by SQLITE
            var connection = Configuration["ConexaoSqlite:SqliteConnectionString"];
            services.AddDbContext<MovieContext>(options =>
                options.UseSqlite(connection)
            );

             services.AddSwaggerGen(c =>
            {
               c.SwaggerDoc("v1", new OpenApiInfo { 
                            Title = "Swagger Movies Demo", 
                            Version = "v1", 
                            Contact = new OpenApiContact {
                                Name = "Gabriel Soares",
                                Email = "gabrielsoares.dev@gmail.com",
                                Url = new Uri("https://github.com/gabr1el94")            
                            } 
                            
                    });
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // active swagger with directory demo
            app.UseSwagger();
             app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Movies Demo V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
