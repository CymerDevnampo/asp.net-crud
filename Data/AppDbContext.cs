using Microsoft.EntityFrameworkCore;
using asp_net_mvc.Models;
using System.Collections.Generic;

namespace asp_net_mvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
