using Lecture8_3.Core.Models;
using Lecture8_3.Core.Repositories;
using System;
using System.ComponentModel.Design;

namespace Lecture8_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepository fileRepository = new FileRepository("Projektai.txt");

            List<Projektas> visiProjektai = fileRepository.GautiVisusProjektus();

            while(true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("1. Perziureti visus projektus");
                Console.WriteLine("2. Peržiūrėti projektą pagal ID");
                Console.WriteLine("3. Pridėti naują projektą");
                Console.WriteLine("4. Ištrinti projektą pagal ID");
                Console.WriteLine("5. Išsaugoti visus pakeitimus į failą");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite norima numeri:");
                int parinktis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (parinktis)
                {
                    case 1:
                        foreach (Projektas a in visiProjektai)
                        {
                            Console.WriteLine($"ID: {a.ProjektoID}, Projektas: {a.ProjektoPavadinimas}, Vadovas/e: {a.VadovoVardas}, Biudzetas: {a.Biudzetas}eur, Pradzia:{a.PradziosData}, Pabaiga:{a.PabaigosData}");
                        }
                        Console.WriteLine();
                        continue;

                    case 2:
                        Console.WriteLine("Iveskite projekto ID, kuri norite pamatyti:");
                        int parinktisID = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        foreach (Projektas a in visiProjektai)
                        {
                            if (parinktisID == a.ProjektoID)
                            {
                                Console.WriteLine($"ID: {a.ProjektoID}, Projektas: {a.ProjektoPavadinimas}, Vadovas/e: {a.VadovoVardas}, Biudzetas: {a.Biudzetas}eur, Pradzia:{a.PradziosData}, Pabaiga:{a.PabaigosData}");
                            }
                        }
                        Console.WriteLine();
                        continue;

                    case 3:
                        Console.WriteLine("Iveskite projekto ID:");
                        int projektoID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite projekto pavadinima:");
                        string projektoPavadinimas = Console.ReadLine();
                        Console.WriteLine("Iveskite projekto vadovo varda:");
                        string vadovoVardas = Console.ReadLine();
                        Console.WriteLine("Iveskite projekto biudzeta (eur):");
                        double biudzetas = double.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite projekto pradzios data (yyyy-mm-dd):");
                        DateTime pradziosData = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite projekto pabaigos data (yyyy-mm-dd):");
                        DateTime pabaigosData = DateTime.Parse(Console.ReadLine());

                        visiProjektai.Add(new Projektas(projektoID, projektoPavadinimas, vadovoVardas, biudzetas, pradziosData, pabaigosData));
                        Console.WriteLine("Projektas pridetas prie saraso!");
                        Console.WriteLine();
                        continue;

                    case 4:
                        Console.WriteLine("Iveskite projekto ID, kuri norite istrinti:");
                        int istrintiID = int.Parse(Console.ReadLine());
                        for (int i = 0; i < visiProjektai.Capacity; i++)
                        {
                            if (istrintiID == i)
                            {
                                visiProjektai.Remove(visiProjektai[(i-1)]);
                                Console.WriteLine("Projektas istrintas is saraso.");
                            }
                        }
                        Console.WriteLine();
                        continue;

                    case 5:
                        fileRepository.RasytiProjektusIFaila(visiProjektai);
                        Console.WriteLine("Visi projektai naujai irasyti i faila");

                        Console.WriteLine();
                        continue;
                }
            }
        }
    }
}