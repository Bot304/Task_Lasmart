using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task_Lasmart.Models
{
    public class PointContext : DbContext
    {
        public DbSet<Point> Points { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public PointContext(DbContextOptions<PointContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
