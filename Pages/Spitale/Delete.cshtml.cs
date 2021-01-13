using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect1.Data;
using Pop_Simona_Proiect1.Models;

namespace Pop_Simona_Proiect1.Pages.Spitale
{
    public class DeleteModel : PageModel
    {
        private readonly Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context _context;

        public DeleteModel(Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Spital Spital { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spital = await _context.Spital.FirstOrDefaultAsync(m => m.ID == id);

            if (Spital == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spital = await _context.Spital.FindAsync(id);

            if (Spital != null)
            {
                _context.Spital.Remove(Spital);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
