using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect1.Data;
using Pop_Simona_Proiect1.Models;

namespace Pop_Simona_Proiect1.Pages.Categorii
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context _context;

        public IndexModel(Pop_Simona_Proiect1.Data.Pop_Simona_Proiect1Context context)
        {
            _context = context;
        }

        public IList<Categorie> Categorie { get;set; }

        public async Task OnGetAsync()
        {
            Categorie = await _context.Categorie.ToListAsync();
        }
    }
}
