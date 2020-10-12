using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NebbAir.Models;

namespace NebbAir.Data
{
    public class NebbAirContext : DbContext
    {
        public NebbAirContext (DbContextOptions<NebbAirContext> options)
            : base(options)
        {
        }

        public DbSet<NebbAir.Models.Patnici> Patnici { get; set; }
    }
}
