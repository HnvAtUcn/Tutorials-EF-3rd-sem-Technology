using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppBook_DBFirst_2.Models
{
    public partial class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
