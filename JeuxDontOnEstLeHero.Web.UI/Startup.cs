using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using JeuxDontOnEstLeHero.Web.UI.Contraintes;

namespace JeuxDontOnEstLeHero.Web.UI
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
            string connectionString = this.Configuration.GetConnectionString("DefaultContext");
            services.AddDbContext<DefaultContext>(options=>options.UseSqlServer(connectionString));

            services.AddControllersWithViews();

            services.AddTransient<jeudontonestlehero.Core.Data.DAO.DaoAventure>();
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
                endpoints.MapControllerRoute(
                    name: "editmonaventure",
                    pattern: "editer-mon-aventure/{id}",
                    defaults: new
                    {
                        controller = "Aventure",
                        action = "Edit"
                    },
                    constraints: new
                    {
                        id = new AventuresContraintes()
                    }
                ) ;

                endpoints.MapControllerRoute(
                    name: "creermonaventure",
                    pattern: "demarrer-mon-aventure",
                    defaults: new
                    {
                        controller = "Aventure",
                        action = "Create"
                    }
                );

                endpoints.MapControllerRoute(
                    name: "mesaventures",
                    pattern: "mes-aventures",
                    defaults: new
                    {
                        controller = "Aventure",
                        action = "Index"
                    }
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
