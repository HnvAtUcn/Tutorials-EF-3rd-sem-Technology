using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppBook_DBFirst_2.Data;
using WebAppBook_DBFirst_2.Models;

namespace WebAppBook_DBFirst_2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppBook_DBFirst_2.Data.WebAppBook_DBFirst_2Context _context;

        public DetailsModel(WebAppBook_DBFirst_2.Data.WebAppBook_DBFirst_2Context context)
        {
            _context = context;
        }

        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Author.FirstOrDefaultAsync(m => m.AuthorId == id);

            if (Author == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
