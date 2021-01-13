using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_Simona_Proiect1.Data;
using Pop_Simona_Proiect1.Models;

namespace Pop_Simona_Proiect1.Pages.Programari
{
    public class CreateModel : PageModel
    {
        private readonly Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context _context;

        public CreateModel(Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            ViewData["SpitalID"] = new SelectList(_context.Set<Spital>(), "ID", "NumeSpital");
            ViewData["ConsultatieID"] = new SelectList(_context.Set<Consultatie>(), "ID", "TipConsultatie");
            return Page();
        }

        [BindProperty]
        public ProgramareMedic ProgramareMedic { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProgramareMedic.Add(ProgramareMedic);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
