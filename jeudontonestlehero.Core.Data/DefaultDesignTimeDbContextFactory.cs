using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace jeudontonestlehero.Core.Data
{
    class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<DefaultDBContext>
    {
        public DefaultDBContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                               .SetBasePath(path)
                               .AddJsonFile("appsettings.json");


            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder<DefaultDBContext> optionBuilder = new DbContextOptionsBuilder<DefaultDBContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new DefaultDBContext(optionBuilder.Options);
        }
    }
}
