using Lecture8_2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8_2.Core.Repositories
{
    public class FileRepository
    {
        private string _fileLocation;

        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }

        public List<Uzsakymas> GautiVisusUzsakymus()
        {
            List<Uzsakymas> uzsakymai = new List<Uzsakymas>();
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
                    uzsakymai.Add(new Uzsakymas(int.Parse(reiksmes[0]), reiksmes[1], int.Parse(reiksmes[2]), double.Parse(reiksmes[3]), DateOnly.Parse(reiksmes[4])));
                }
            }
            return uzsakymai;
        }
    }
}
