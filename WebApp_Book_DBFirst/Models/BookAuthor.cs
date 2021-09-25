using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Book_DBFirst.Models
{
    public partial class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
