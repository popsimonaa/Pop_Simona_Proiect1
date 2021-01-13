using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pop_Simona_Proiect1.Models
{
    public class Consultatie
    {
        public int ID { get; set; }
        [Display(Name = "Tip Consultatie")]
        public string TipConsultatie { get; set; }
        public ICollection<ProgramareMedic> Programari { get; set; }
    }
}
