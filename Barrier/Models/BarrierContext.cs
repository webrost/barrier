using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Barrier.Models
{
    public class BarrierContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public BarrierContext(DbContextOptions<BarrierContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
