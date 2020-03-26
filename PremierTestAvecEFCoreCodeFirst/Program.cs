using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using System.IO;

namespace PremierTestAvecEFCoreCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
            
            var config = configurationBuilder.Build();
            string connectionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            dbContextOptionsBuilder.UseSqlServer(connectionString);

            using (DefaultContext defaultContext = new DefaultContext(dbContextOptionsBuilder.Options))
            {
                var query = from droide in defaultContext.Droides
                            select droide;
                foreach (var item in query.ToList())
                {

                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
