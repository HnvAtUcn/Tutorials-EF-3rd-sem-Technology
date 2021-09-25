using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WepApp_Movies_ModelFirst.Data;
using WepApp_Movies_ModelFirst.Models;

namespace WepApp_Movies_ModelFirst.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WepApp_Movies_ModelFirst.Data.WepApp_Movies_ModelFirstContext _context;

        public IndexModel(WepApp_Movies_ModelFirst.Data.WepApp_Movies_ModelFirstContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
