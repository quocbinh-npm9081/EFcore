using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WpfApp1.Data.Configurations;
using WpfApp1.Data.Enities;

namespace WpfApp1.Data.EFCore
{
    public class AddDbContext: DbContext
    {
        public AddDbContext(DbContextOptions options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        //su dung
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UseRoles { get; set; }   
    }
}
