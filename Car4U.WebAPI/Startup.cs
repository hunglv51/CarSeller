using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car4U.Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Car4U.ApplicationCore.Interfaces;
using Car4U.Infrastructure.Logging;
using Car4U.Infrastructure.Data.Repositories;
using Car4U.WebAPI.Services;

namespace Car4U.WebAPI
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
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped(typeof(INotificationRepository), typeof(NotificationRepository));
            services.AddScoped(typeof(IPostRepository), typeof(PostRepository));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            services.AddEntityFrameworkNpgsql().AddDbContext<CarSellerContext>(o => o.UseNpgsql(Configuration.GetConnectionString("CarSellerContext")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
