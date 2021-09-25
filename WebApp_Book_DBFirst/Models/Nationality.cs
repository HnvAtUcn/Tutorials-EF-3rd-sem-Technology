using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Book_DBFirst.Models
{
    public partial class Nationality
    {
        public Nationality()
        {
            Authors = new HashSet<Author>();
        }

        public int NationalityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
