using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Pop_Simona_Proiect1.Models
{
    public class ConsultatieCategorie
    {
        public int ID { get; set; }
        public int ConsultatieID { get; set; }
        public ProgramareMedic ProgramareMedic { get; set; }
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }
    }
}
