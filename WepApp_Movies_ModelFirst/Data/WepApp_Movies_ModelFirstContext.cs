using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WepApp_Movies_ModelFirst.Models;

namespace WepApp_Movies_ModelFirst.Data
{
    public class WepApp_Movies_ModelFirstContext : DbContext
    {
        public WepApp_Movies_ModelFirstContext (DbContextOptions<WepApp_Movies_ModelFirstContext> options)
            : base(options)
        {
        }

        public DbSet<WepApp_Movies_ModelFirst.Models.Movie> Movie { get; set; }
    }
}
