using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Csharp_R_H25_Examen_Final
{
    public class Plante : OrganismeVivant
    {
        public string NomCommun { get; set; }
        public string FamilleBotanique { get; set; }
        public string Type { get; set; }
        public List<Caracteristique> Caracteristiques { get; set; } = new List<Caracteristique>();
        public List<Environnement> Environnements { get; set; } = new List<Environnement>();
    }
}
