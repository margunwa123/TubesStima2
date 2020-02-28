using System;
using System.Collections.Generic;

namespace TubesStima2CoronaVirus
{
    class TxtReader
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
            int number = (int) char.GetNumericValue(linesInFile[0][0]);
            return number;
        }
        public void getNumber(bool X)
        {
            if(X)
            {
                Console.WriteLine(linesInFile[0][0]);
            }
        }
        public void printAllLines()
        {
            foreach (string line in linesInFile)
            {
                Console.WriteLine(line);
            }
        }
    }
    class PopulationReader : TxtReader
    {
        private Dictionary<char, int> populationPerCity;
        public PopulationReader(string path) : base(path)
        {
            int population;
            char city;
            if(linesInFile.Length > 0)
            {
                for (int i = 1; i < linesInFile.Length; i++)
                {
                    city = linesInFile[i][0];
                    population = int.Parse(linesInFile[i].Substring(2));
                    populationPerCity.Add(city, population);
                }
            }
        }
        public char getKotaAwal()
        {
            return this.linesInFile[0][2];
        }

    }
    class GraphReader : TxtReader
    {
        public GraphReader(string path) : base(path)
        {

        }
    }
    struct TrailElement
    {
        public char trail;
        public double probability;
    }
    class GraphElement
    {
        public char node;
        public List<TrailElement> trails;
        public GraphElement(char node)
        {
            trails = new List<TrailElement>();
            this.node = node;
        }
    }
    class Graph
    {
        private List<GraphElement> nodes;
        private int size;
        public Graph(int numOfNodes)
        {
            nodes = new List<GraphElement>();
            for (int i = 0; i < numOfNodes; i++)
            {
                char idx = (char)(65 + i);
                GraphElement temp = new GraphElement(idx);
                nodes.Add(temp);
            }
            this.size = numOfNodes;
        }
        public Graph() : this(10) { }
        public void addElement(char index)
        {
            if (nodesContain(index) > -1)
            {
                GraphElement temp = new GraphElement(index);
                nodes.Add(temp);
            }
        }
        public void setElement(int index, GraphElement temp)
        {
            nodes.Insert(index, temp);
        }
        public int nodesContain(char node)
        {
            int i = 0;
            foreach (GraphElement val in nodes)
            {
                if (val.node == node)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public void addTrail(char nodeElement, char trailElement, double probability)
        {
            int nodeIndex = nodesContain(nodeElement);
            int trailIndex = nodesContain(trailElement);
            if (nodeIndex > -1 && trailIndex > -1)
            {
                TrailElement temp;
                temp.probability = probability;
                temp.trail = trailElement;
                nodes[nodeIndex].trails.Add(temp);
            }
            else
            {
                Console.WriteLine("Node tidak ada");
            }
        }
        public void printInfo()
        {
            foreach (GraphElement val in nodes)
            {
                Console.Write("{0} : ", val.node);
                foreach (TrailElement trailEl in val.trails)
                {
                    Console.Write("{0},{1} ", trailEl.trail, trailEl.probability);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph A = new Graph();
            string num = "A 5000";
            A.addTrail('A', 'B', 0.5);
            A.printInfo();
            TxtReader Graph = new TxtReader("C:/Users/Asus/Desktop/Semester_IV/Tubes & tucil/Stima/TubesStima2CoronaVirus/TubesStima2CoronaVirus/Graph.txt");
            TxtReader Populasi = new TxtReader("C:/Users/Asus/Desktop/Semester_IV/Tubes & tucil/Stima/TubesStima2CoronaVirus/TubesStima2CoronaVirus/Populasi.txt");
            Graph.printAllLines();
            Console.WriteLine(int.Parse(num.Substring(2)));
        }
    }
}
