using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using skyshopCore.Data;
using skyshopCore.infrastructure;
using skyshopCore.Models;
using MailKit;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace skyshopCore
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AppUser,IdentityRole>(options=>{
                 options.SignIn.RequireConfirmedEmail = true;
            })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();
             
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IEmailSender, EmailSender>();
             services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
                 services.AddSession(options => {  
                     options.IdleTimeout = TimeSpan.FromMinutes(5);
                     options.Cookie.HttpOnly = true;
                     options.Cookie.IsEssential = true;
                 });
            //  services.AddSingleton<IHostingEnvironment>(new HostingEnvironment());
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext db, 
                               UserManager<AppUser> usermanager,RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Views/Shared/Error.cshtml");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            db.DataSeed(usermanager,roleManager);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseSession();  

            app.UseMvc(routes =>
            {
                    routes.MapRoute(
                    name: "Identity",
                    template: "{area=exists}/{controller=Dashboard}/{action=Index}/{id?}");

                    routes.MapRoute(
                    name: "Supplier",
                    template: "{area=exists}/{controller=Supplier}/{action=Index}/{id?}");

                //    routes.MapRoute(
                //      name: "UserPanel12",
                //     template: "panel/{controller}/{action}",
                //     new { area="userpanel",Controller="panel",action="index"});

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");


            });
        }
    }
}
