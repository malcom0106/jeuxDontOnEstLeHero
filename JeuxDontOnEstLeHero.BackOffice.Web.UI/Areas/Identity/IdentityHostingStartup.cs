using System;
using JeuxDontOnEstLeHero.BackOffice.Web.UI.Areas.Identity.Data;
using JeuxDontOnEstLeHero.BackOffice.Web.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(JeuxDontOnEstLeHero.BackOffice.Web.UI.Areas.Identity.IdentityHostingStartup))]
namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<JeuxDontOnEstLeHeroBackOfficeWebUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("JeuxDontOnEstLeHeroBackOfficeWebUIContextConnection")));

                services.AddDefaultIdentity<UserFacebook>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<JeuxDontOnEstLeHeroBackOfficeWebUIContext>();
            });
        }
    }
}