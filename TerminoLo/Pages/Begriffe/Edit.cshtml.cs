using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TerminoLo.Data;

namespace TerminoLo.Pages.Begriffe
{
    public class EditModel : PageModel
    {
        private readonly TerminoLo.Data.TerminoLoDbContext _context;

        public EditModel(TerminoLo.Data.TerminoLoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Begriff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BegriffExists(Begriff.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BegriffExists(Guid id)
        {
            return _context.Begriffe.Any(e => e.Id == id);
        }
    }
}
