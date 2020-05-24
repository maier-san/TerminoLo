using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TerminoLo.Data;

namespace TerminoLo.Pages.Begriffe
{
    public class IndexModel : PageModel
    {
        private readonly TerminoLo.Data.TerminoLoDbContext _context;

        public IndexModel(TerminoLo.Data.TerminoLoDbContext context)
        {
            _context = context;
        }

        public IList<Begriff> Begriff { get;set; }

        public async Task OnGetAsync()
        {
            Begriff = await _context.Begriffe.ToListAsync();
        }
    }
}
