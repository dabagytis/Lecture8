using Lecture8_2.Core.Models;
using Lecture8_2.Core.Repositories;
using System;
using System.ComponentModel.Design;

namespace Lecture8_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepository fileRepository = new FileRepository("Uzsakymai.txt");

            List<Uzsakymas> visiUzsakymai = fileRepository.GautiVisusUzsakymus();

            int prioritetiniai = 0;

            foreach (Uzsakymas a in visiUzsakymai)
            {
                Console.WriteLine($"{a.UzsakymoNumeris} {a.KlientoVardas} {a.PrekiuKiekis} {a.BendraSuma} {a.UzsakymoData}");
                if(a.UzsakymoData > DateOnly.Parse("2024-10-22") && a.BendraSuma >= 100)
                {
                    Console.WriteLine($"Uzsakymas {a.UzsakymoNumeris} is kliento {a.KlientoVardas} yra prioritetinis");
                    prioritetiniai++;
                    Console.WriteLine();
                }
                else if(a.PrekiuKiekis >= 10 && a.BendraSuma < 50)
                {
                    Console.WriteLine($"Uzsakymas {a.UzsakymoNumeris} is kliento {a.KlientoVardas} turi dideli kieki, bet zema verte");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Uzsakymas {a.UzsakymoNumeris} is kliento {a.KlientoVardas} neatitinka specialiu kriteriju ir nera prioritetinis");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Prioritetiniu uzsakymu kiekis: {prioritetiniai}");
        }
    }
}