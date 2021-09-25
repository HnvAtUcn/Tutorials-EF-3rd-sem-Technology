using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppBook_DBFirst_2.Models
{
    public partial class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int NationalityId { get; set; }
    }
}
