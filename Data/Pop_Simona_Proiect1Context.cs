using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Simona_Proiect1.Models;

namespace Pop_Simona_Proiect1.Data
{
    public class Pop_Simona_Proiect1Context : DbContext
    {
        public Pop_Simona_Proiect1Context (DbContextOptions<Pop_Simona_Proiect1Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Simona_Proiect1.Models.ProgramareMedic> ProgramareMedic { get; set; }

        public DbSet<Pop_Simona_Proiect1.Models.Spital> Spital { get; set; }

        public DbSet<Pop_Simona_Proiect1.Models.Consultatie> Consultatie { get; set; }

    }
}
