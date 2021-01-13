using System;

using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pop_Simona_Proiect1.Models
{
    public class Spital
    {
        public int ID { get; set; }
        [Display(Name = "Nume Spital")]
        public string NumeSpital { get; set; }
        public ICollection<ProgramareMedic> Programari { get; set; } //navigation property
    }
}
