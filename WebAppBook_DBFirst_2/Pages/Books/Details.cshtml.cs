using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppBook_DBFirst_2.Data;
using WebAppBook_DBFirst_2.Models;

namespace WebAppBook_DBFirst_2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppBook_DBFirst_2.Data.WebAppBook_DBFirst_2Context _context;

        public DetailsModel(WebAppBook_DBFirst_2.Data.WebAppBook_DBFirst_2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.BookId == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
