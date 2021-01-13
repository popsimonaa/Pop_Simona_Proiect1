using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect1.Data;
using Pop_Simona_Proiect1.Models;

namespace Pop_Simona_Proiect1.Pages.Consultatii
{
    public class DeleteModel : PageModel
    {
        private readonly Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context _context;

        public DeleteModel(Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Consultatie Consultatie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consultatie = await _context.Consultatie.FirstOrDefaultAsync(m => m.ID == id);

            if (Consultatie == null)
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

            Consultatie = await _context.Consultatie.FindAsync(id);

            if (Consultatie != null)
            {
                _context.Consultatie.Remove(Consultatie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
