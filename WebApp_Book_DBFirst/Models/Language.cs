using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Book_DBFirst.Models
{
    public partial class Language
    {
        public Language()
        {
            Books = new HashSet<Book>();
        }

        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
