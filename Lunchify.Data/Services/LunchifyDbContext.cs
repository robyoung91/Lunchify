using Lunchify.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchify.Data.Services
{
    public class LunchifyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Lunch> Lunches { get; set; }
        public DbSet<LunchEvent> LunchEvents { get; set; }

    }
}
