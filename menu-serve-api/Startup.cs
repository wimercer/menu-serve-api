using menu_serve_api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace menu_serve_api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // TODO : work out how to hide database connection string SECURITY!!!
            //string connectionString = Environment.GetEnvironmentVariable("MenuServeDatabase", EnvironmentVariableTarget.Machine);
            string connectionString = Configuration.GetConnectionString("menu_serve");

            Console.WriteLine(connectionString);
            
            services.AddDbContext<MenuServeDBContext>(options => options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // TODO  : work out how to automate migrations
            // app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope().ServiceProvider.GetRequiredService<MenuServeDBContext>().Database.Migrate();

            app.UseMvc();
        }
    }
}
