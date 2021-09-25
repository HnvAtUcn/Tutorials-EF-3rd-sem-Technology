using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Book_DBFirst.Models
{
    public partial class Genre
    {
        public Genre()
        {
            BookGenres = new HashSet<BookGenre>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}
