using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8_2.Core.Models
{
    public class Uzsakymas
    {
        public int UzsakymoNumeris { get; set; }
        public string KlientoVardas { get; set; }
        public int PrekiuKiekis { get; set; }
        public double BendraSuma { get; set; }
        public DateOnly UzsakymoData { get; set; }

        public Uzsakymas()
        {

        }

        public Uzsakymas(int uzsakymoNumeris, string klientoVardas, int prekiuKiekis, double bendraSuma, DateOnly uzsakymoData)
        {
            UzsakymoNumeris = uzsakymoNumeris;
            KlientoVardas = klientoVardas;
            PrekiuKiekis = prekiuKiekis;
            BendraSuma = bendraSuma;
            UzsakymoData = uzsakymoData;
        }
    }
}
