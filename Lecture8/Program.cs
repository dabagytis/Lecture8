using Lecture8_1.Core.Models;
using Lecture8_1.Core.Repositories;
using System;
using System.ComponentModel.Design;

namespace Lecture8_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileRepository fileRepository = new FileRepository("Studentai.csv");

            List<Studentas> visiStudentai = fileRepository.GautiVisusStudentus();

            foreach (Studentas a in visiStudentai)
            {
                Console.WriteLine($"{a.Vardas} {a.Pavarde} {a.Amzius} {a.Vidurkis}");
                if(a.Amzius > 20 && a.Vidurkis > 7)
                {
                    Console.WriteLine($"Studentas {a.Vardas} {a.Pavarde} atitinka kriterijus");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Studentas {a.Vardas} {a.Pavarde} neatitinka kriteriju");
                    Console.WriteLine();
                }
            }
        }
    }
}