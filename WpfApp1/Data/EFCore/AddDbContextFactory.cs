using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.EFCore
{
    public class AddDbContextFactory : IDesignTimeDbContextFactory<AddDbContext>
    {
        public AddDbContext CreateDbContext(string[] args) {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting").Build();

            var connectionString = configuration.GetConnectionString("connec");
            var optionBuilder = new DbContextOptionsBuilder<AddDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new AddDbContext(optionBuilder.Options);

        }
    }
}
