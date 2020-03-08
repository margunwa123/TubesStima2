using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubesStimaVisual.src.GraphClass;

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
    class GraphReader : TxtReader
    {
        public Dictionary<char, List<TrailElement>> connectionsAndProbability;
        public GraphReader(string path) : base(path)
        {
            connectionsAndProbability = new Dictionary<char, List<TrailElement>>();
            for (int i = 1; i < linesInFile.Length; i++)
            {
                char node = linesInFile[i][0];
                char trail = linesInFile[i][2];
                double probability = double.Parse(linesInFile[i].Substring(4));
                TrailElement temp = new TrailElement(trail, probability);
                if (connectionsAndProbability.ContainsKey(node))
                {
                    connectionsAndProbability[node].Add(temp);
                }
                else
                {
                    List<TrailElement> tempList = new List<TrailElement>();
                    tempList.Add(temp);
                    connectionsAndProbability.Add(node, tempList);
                }
            }
        }
    }

    abstract class TxtReader
    {
        protected string[] linesInFile;
        protected string path;
        public TxtReader(string path)
        {
            this.path = path;
            linesInFile = System.IO.File.ReadAllLines(path);
        }
        public int getNumber()
        {
            int number = (int)char.GetNumericValue(linesInFile[0][0]);
            return number;
        }
    }
}
