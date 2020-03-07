﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual
{
    class TrailElement
    {
        public char trail;
        public double probability;
        public TrailElement(char trail, double probability)
        {
            this.trail = trail;
            this.probability = probability;
        }
    }
    class GraphElement
    {
        public char node;
        public int population;
        public List<TrailElement> trails;
        public GraphElement(char node, int population)
        {
            trails = new List<TrailElement>();
            this.population = population;
            this.node = node;
        }
        public GraphElement(char node) : this(node, 0) { }
        public void addPopulation(int population)
        {
            this.population += population;
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
            size = numOfNodes;
        }
        public Graph() : this(0) { }
        public Graph(PopulationReader populationReader, GraphReader graphReader) : this()
        {
            size = populationReader.getBanyakKota();
            foreach (var(city, population) in populationReader.populationPerCity.Select(X=>(X.Key, X.Value)))
            {
                nodes.Add(new GraphElement(city, population));
            }
            int iterator = 0;
            foreach (var(cityInGraph, trails) in graphReader.connectionsAndProbability.Select(X=>(X.Key, X.Value)))
            {
                int indexOfCity = indexOf(cityInGraph);
                foreach (TrailElement trail in trails)
                {
                    nodes[indexOfCity].trails.Add(new TrailElement(trail.trail, trail.probability));
                }
                iterator++;
            }

        }
        public int indexOf(char city)
        {
            int iterator = 0;
            foreach (GraphElement node in nodes)
            {
                if (node.node == city)
                {
                    return iterator;
                }
                iterator++;
            }
            return -1;
        }
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
                TrailElement temp = new TrailElement(trailElement, probability);
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