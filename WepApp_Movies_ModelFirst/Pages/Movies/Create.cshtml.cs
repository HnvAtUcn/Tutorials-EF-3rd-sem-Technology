using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WepApp_Movies_ModelFirst.Data;
using WepApp_Movies_ModelFirst.Models;

namespace WepApp_Movies_ModelFirst.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly WepApp_Movies_ModelFirst.Data.WepApp_Movies_ModelFirstContext _context;

        public CreateModel(WepApp_Movies_ModelFirst.Data.WepApp_Movies_ModelFirstContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
