using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)  // DbContext available microft.entityframworkcore pakg
    {
        //public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
