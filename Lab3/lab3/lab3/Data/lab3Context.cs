using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab3.Models;

namespace lab3.Data
{
    public class lab3Context : DbContext
    {
        public lab3Context (DbContextOptions<lab3Context> options)
            : base(options)
        {
        }

        public DbSet<lab3.Models.Movie> Movie { get; set; } = default!;
    }
}
