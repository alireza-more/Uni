using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Uni.Data
{
    public class UniContext : DbContext
    {
        public UniContext (DbContextOptions<UniContext> options)
            : base(options)
        {
        }

        public DbSet<Uni.Data.User> User { get; set; }
    }
}
