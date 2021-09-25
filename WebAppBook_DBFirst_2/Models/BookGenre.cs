using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppBook_DBFirst_2.Models
{
    public partial class BookGenre
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
    }
}
