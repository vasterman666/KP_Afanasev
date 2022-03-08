using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace KP_Afanasev.Data
{
    public class KP_AfanasevContext : DbContext
    {
        public KP_AfanasevContext (DbContextOptions<KP_AfanasevContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
