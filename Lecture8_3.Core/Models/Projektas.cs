using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8_3.Core.Models
{
    public class Projektas
    {
        public int ProjektoID { get; set; }
        public string ProjektoPavadinimas { get; set; }
        public string VadovoVardas { get; set; }
        public double Biudzetas { get; set; }
        public DateTime PradziosData { get; set; }
        public DateTime PabaigosData { get; set; }

        public Projektas()
        {

        }

        public Projektas(int projektoID, string projektoPavadinimas, string vadovoVardas, double biudzetas, DateTime pradziosData, DateTime pabaigosData)
        {
            ProjektoID = projektoID;
            ProjektoPavadinimas = projektoPavadinimas;
            VadovoVardas = vadovoVardas;
            Biudzetas = biudzetas;
            PradziosData = pradziosData;
            PabaigosData = pabaigosData;
        }
    }
}
