using Lecture8_3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8_3.Core.Repositories
{
    public class FileRepository
    {
        private string _fileLocation;

        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Projektas> GautiVisusProjektus()
        {
            List<Projektas> projektai = new List<Projektas>();
            using (StreamReader sr = new StreamReader(_fileLocation))
            {
                while (!sr.EndOfStream)
                {
                    string eilute = sr.ReadLine();
                    if (string.IsNullOrEmpty(eilute))
                    {
                        break;
                    }
                    string[] reiksmes = eilute.Split(',');
                    projektai.Add(new Projektas(int.Parse(reiksmes[0]), reiksmes[1], reiksmes[2], double.Parse(reiksmes[3]), DateTime.Parse(reiksmes[4]), DateTime.Parse(reiksmes[5])));
                }
            }
            return projektai;
        }
        public void RasytiProjektusIFaila(List<Projektas> projektai)
        {
            using (StreamWriter sw = new StreamWriter(_fileLocation))
            {
                foreach (Projektas a in projektai)
                {
                    sw.WriteLine($"{a.ProjektoID},{a.ProjektoPavadinimas},{a.VadovoVardas},{a.Biudzetas},{a.PradziosData},{a.PabaigosData}");
                }
                sw.Close();
            }
        }
    }
}
