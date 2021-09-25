using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppBook_DBFirst_2.Models;

namespace WebAppBook_DBFirst_2.Data
{
    public class WebAppBook_DBFirst_2Context : DbContext
    {
        public WebAppBook_DBFirst_2Context (DbContextOptions<WebAppBook_DBFirst_2Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppBook_DBFirst_2.Models.Language> Language { get; set; }

        public DbSet<WebAppBook_DBFirst_2.Models.Book> Book { get; set; }

        public DbSet<WebAppBook_DBFirst_2.Models.Author> Author { get; set; }

        public DbSet<WebAppBook_DBFirst_2.Models.Genre> Genre { get; set; }
    }
}
