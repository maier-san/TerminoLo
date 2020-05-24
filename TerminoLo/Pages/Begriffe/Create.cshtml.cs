using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TerminoLo.Data;

namespace TerminoLo.Pages.Begriffe
{
    public class CreateModel : PageModel
    {
        private readonly TerminoLo.Data.TerminoLoDbContext _context;

        public CreateModel(TerminoLo.Data.TerminoLoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Begriff Begriff { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Begriffe.Add(Begriff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}