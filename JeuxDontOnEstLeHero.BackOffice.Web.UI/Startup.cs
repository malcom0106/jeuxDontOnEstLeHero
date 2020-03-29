using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;
using jeudontonestlehero.Core.Data.Models;
using JeuxDontOnEstLeHero.BackOffice.Web.UI.Contraintes;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI
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
            var FacebookID = this.Configuration["apis:facebook:id"];
            var FacebookSecret = this.Configuration["apis:facebook:secret"];
            services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = FacebookID;
                options.AppSecret = FacebookSecret;
            });

            string connectionString = this.Configuration.GetConnectionString("DefaultContext");
            services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString));

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
            }
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "editparagraphe",
                    pattern: "edition-paragraphe/{id}",
                    defaults: new 
                    {
                        controller = "Paragraphe",
                        action = "Edit"
                    },
                    constraints: new 
                    { 
                        //id=@"\d+"
                        id = new LoginContraintes()
                    }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
