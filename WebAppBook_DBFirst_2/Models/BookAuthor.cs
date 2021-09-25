using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppBook_DBFirst_2.Models
{
    public partial class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
    }
}
