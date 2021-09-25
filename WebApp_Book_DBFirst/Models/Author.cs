using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Book_DBFirst.Models
{
    public partial class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int NationalityId { get; set; }

        public virtual Nationality Nationality { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
