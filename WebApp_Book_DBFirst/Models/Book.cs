using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Book_DBFirst.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthors = new HashSet<BookAuthor>();
            BookGenres = new HashSet<BookGenre>();
        }

        public int BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Cover { get; set; }
        public DateTime? DateAcquired { get; set; }
        public bool Active { get; set; }
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookGenre> BookGenres { get; set; }
    }
}
