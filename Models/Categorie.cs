using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pop_Simona_Proiect1.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        [Display(Name = "Tipul consultatiei")]
        public string DenumireConsultatie { get; set; }
        public ICollection<ConsultatieCategorie> ConsultatieCategorii { get; set; }
    }
}
