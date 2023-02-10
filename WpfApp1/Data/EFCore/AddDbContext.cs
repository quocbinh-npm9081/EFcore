using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WpfApp1.Data.EFCore
{
    public class AddDbContext: DbContext
    {
        public AddDbContext(DbContextOptions options) :base(options)
        {
        }
    }
}
