using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubesStimaVisual.src.FileReaderClass;

namespace TubesStimaVisual.src.GraphClass
{
    public partial class Graph
    {
        private List<GraphElement> nodes;
        private int size;
        public Graph(int numOfNodes)
        {
            nodes = new List<GraphElement>();
            for (int i = 0; i < numOfNodes; i++)
            {
                int ASCIIChar = 65 + i;
                char idx = (char) ASCIIChar;
                GraphElement temp = new GraphElement(idx);
                nodes.Add(temp);
            }
            size = numOfNodes;
        }
        public Graph() : this(0) { }
        internal Graph(PopulationReader populationReader, GraphReader graphReader) : this()
        {
            size = populationReader.getBanyakKota();
            foreach (var(city, population) in populationReader.populationPerCity.Select(X=>(X.Key, X.Value)))
            {
                nodes.Add(new GraphElement(city, population));
            }
            nodes[IndexOf(populationReader.getKotaAwal())].setKotaAwal();
            int iterator = 0;
            foreach (var(cityInGraph, trails) in graphReader.connectionsAndProbability.Select(X=>(X.Key, X.Value)))
            {
                int indexOfCity = IndexOf(cityInGraph);
                foreach (TrailElement trail in trails)
                {
                    nodes[indexOfCity].trails.Add(new TrailElement(trail.trail, trail.probability));
                }
                iterator++;
            }

        }
        public int IndexOf(char city)
        {
            for(int i = 0; i < size; i++)
            {
                if(nodes[i].node == city)
                {
                    return i;
                }
            }
            return -1; //kalo gaada
        }
        public void addElement(char index)
        {
            if (IndexOf(index) > -1)
            {
                GraphElement temp = new GraphElement(index);
                nodes.Add(temp);
            }
        }
        public int getJumlahKota()
        {
            return size;
        }
        public void setElement(int index, GraphElement temp)
        {
            nodes.Insert(index, temp);
        }
        public void addTrail(char nodeElement, char trailElement, double probability)
        {
            int nodeIndex = IndexOf(nodeElement);
            TrailElement temp = new TrailElement(trailElement, probability);
            nodes[nodeIndex].trails.Add(temp);
        }
        public void setCityInfected(char city)
        {
            nodes[IndexOf(city)].setInfectedTrue();
        }

        
        //
        //METODE DEBUGGING
        //
        public void printInfo()
        {
            foreach (GraphElement val in nodes)
            {
                Console.Write("Kota {0} dengan populasi {1} dan hubungan : ", val.node, val.population);
                foreach (TrailElement trailEl in val.trails)
                {
                    Console.Write("{0}, {1}  ", trailEl.trail, trailEl.probability);
                }
                Console.WriteLine();
            }
        }
    }
}
