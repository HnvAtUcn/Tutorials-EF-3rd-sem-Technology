using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppBook_DBFirst_2.Data;
using WebAppBook_DBFirst_2.Models;

namespace WebAppBook_DBFirst_2.Pages.Languages
{
    public class IndexModel : PageModel
    {
        private readonly WebAppBook_DBFirst_2.Data.WebAppBook_DBFirst_2Context _context;

        public IndexModel(WebAppBook_DBFirst_2.Data.WebAppBook_DBFirst_2Context context)
        {
            _context = context;
        }

        public IList<Language> Language { get;set; }

        public async Task OnGetAsync()
        {
            Language = await _context.Language.ToListAsync();
        }
    }
}
