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
    public class DetailsModel : PageModel
    {
        private readonly TerminoLo.Data.TerminoLoDbContext _context;

        public DetailsModel(TerminoLo.Data.TerminoLoDbContext context)
        {
            _context = context;
        }

        public Begriff Begriff { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Begriff = await _context.Begriffe.FirstOrDefaultAsync(m => m.Id == id);

            if (Begriff == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
