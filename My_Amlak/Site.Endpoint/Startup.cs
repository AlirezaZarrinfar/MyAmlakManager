using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using My_Amlak.Application.Interfaces;
using My_Amlak.Application.Services.Amlaks.Commands;
using My_Amlak.Application.Services.Amlaks.Commands.AddMelk;
using My_Amlak.Application.Services.Amlaks.Queries.GetAmlaks;
using My_Amlak.Application.Services.Amlaks.Queries.GetUpdate;
using My_Amlak.Application.Services.Amlaks.Queries.ShowFacilities;
using My_Amlak.Application.Services.Users.Commands.AddUsers;
using My_Amlak.Application.Services.Users.Commands.DeleteUsers;
using My_Amlak.Application.Services.Users.Commands.SetUsersUpdate;
using My_Amlak.Application.Services.Users.Queries.GetUsers;
using My_Amlak.Application.Services.Users.Queries.GetUsersUpdate;
using My_Amlak.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Endpoint
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
            services.AddScoped<ISetUpdateAmlaksService, SetUpdateAmlaksService>();
            services.AddScoped<IGetUpdateAmlaksService, GetUpdateAmlaksService>();
            services.AddScoped<IAddMelkService, AddMelkService>();
            services.AddScoped<IDeleteAmlakService, DeleteAmlakService>();
            services.AddScoped<IShowFacilitiesService, ShowFacilitiesService>();
            services.AddScoped<IGetAmlaksService, GetAmlaksService>();
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IAddUsersService, AddUsersService>();
            services.AddScoped<IDeleteUsersService, DeleteUsersService>();
            services.AddScoped<IGetUsersUpdateService, GetUsersUpdateService>();
            services.AddScoped<ISetUsersUpdateService, SetUsersUpdateService>();
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            string constr = @"Data Source =. ;Initial Catalog = MyAmlak_DB; Integrated Security = True;";
            services.AddEntityFrameworkSqlServer().AddDbContext<DatabaseContext>(option => option.UseSqlServer(constr));
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
               

            });
        }
    }
}
