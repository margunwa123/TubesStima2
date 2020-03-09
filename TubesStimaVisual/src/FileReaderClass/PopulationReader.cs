using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual.src.FileReaderClass
{
    class PopulationReader : TxtReader
    {
        public Dictionary<char, int> populationPerCity;
        public PopulationReader(string path) : base(path)
        {
            populationPerCity = new Dictionary<char, int>();
            int population;
            char city;
            if (linesInFile.Length > 0)
            {
                for (int i = 1; i < linesInFile.Length; i++)
                {
                    Console.WriteLine(linesInFile[i]);
                    city = linesInFile[i][0];
                    population = int.Parse(linesInFile[i].Substring(2));
                    populationPerCity.Add(city, population);
                }
            }
        }
        public int getBanyakKota()
        {
            return (int)char.GetNumericValue(linesInFile[0][0]);
        }
        public char getKotaAwal()
        {
            return linesInFile[0][2];
        }
        public void printPopulation()
        {
            foreach (var (city, population) in populationPerCity.Select(X => (X.Key, X.Value)))
            {
                Console.WriteLine("Population City {0} : {1}", city, population);
            }
        }
    }
}
