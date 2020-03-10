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
        private Dictionary<char, GraphElement> nodes;
        private int size;
        private char kotaAwal;
        public Graph(int numOfNodes)
        {
            nodes = new Dictionary<char, GraphElement>();
            for (int i = 0; i < numOfNodes; i++)
            {
                int ASCIIChar = 65 + i;
                char idx = (char) ASCIIChar;
                GraphElement temp = new GraphElement(idx);
                nodes.Add(idx, temp);
            }
            size = numOfNodes;
            kotaAwal = 'A';
        }
        public Graph() : this(0) { }
        internal Graph(PopulationReader populationReader, GraphReader graphReader) : this()
        {
            size = populationReader.getBanyakKota();
            foreach (var(city, population) in populationReader.populationPerCity.Select(X=>(X.Key, X.Value)))
            {
                nodes.Add(city, new GraphElement(city, population));
            }
            nodes[populationReader.getKotaAwal()].setKotaAwal();
            kotaAwal = populationReader.getKotaAwal();
            int iterator = 0;
            foreach (var(cityInGraph, trails) in graphReader.connectionsAndProbability.Select(X=>(X.Key, X.Value)))
            {
                foreach (TrailElement trail in trails)
                {
                    nodes[cityInGraph].trails.Add(new TrailElement(trail.trail, trail.probability));
                }
                iterator++;
            }
        }
        public Graph(string populationPath, string graphPath) : this(new PopulationReader(populationPath), new GraphReader(graphPath)) { }
        public void addElement(char index)
        {
            if (!nodes.ContainsKey(index))
            {
                GraphElement temp = new GraphElement(index);
                nodes.Add(index, temp);
            }
        }
        public GraphElement getElement(char index)
        {
            return nodes[index];
        }
        public void setElement(char index, GraphElement temp)
        {
            nodes[index] = temp;
        }
        public void addTrail(char nodeIndex, char trailElement, double probability)
        {
            TrailElement temp = new TrailElement(trailElement, probability);
            nodes[nodeIndex].trails.Add(temp);
        }
        public void setCityInfected(char city, int timeInfected)
        {
            nodes[city].timeInfected = timeInfected;
        }

        public List<string> infoGraphInListOfString()
        {
            List<string> result = new List<string>();
            foreach(var(key,val) in nodes.Select(X=>(X.Key,X.Value)))
            {
                string deskripsiKota = "Kota " + key + " dengan populasi " + val.population + " dan hubungan : ";
                foreach(TrailElement trailEl in val.trails)
                {
                    deskripsiKota += (trailEl.trail + ", " + trailEl.probability + " ");
                }
                deskripsiKota += "\n dengan waktu terinfeksi " + val.timeInfected + " dan jumlah yg terinfeksi" + val.jumlahMasyarakatTerinfeksi;
                result.Add(deskripsiKota);
            }
            return result;
        }
        //
        //METODE DEBUGGING
        //
        public void printInfo()
        {
            foreach (var (key, val) in nodes.Select(X => (X.Key, X.Value)))
            {
                Console.Write("Kota {0} dengan populasi {1} dan hubungan : ", val.node, val.population);
                foreach (TrailElement trailEl in val.trails)
                {
                    Console.Write("{0}, {1}  ", trailEl.trail, trailEl.probability);
                }
                Console.WriteLine();
            }
        }

        public void solveBFS(int waktu)
        {
            Queue<char> q = new Queue<char>();
            q.Enqueue(kotaAwal);
            while(!(q.Count == 0))
            {
                char kotaYangDikunjungi = q.Dequeue();
                int sudahBerapaLamaTerinfeksi = waktu - nodes[kotaYangDikunjungi].timeInfected;
                nodes[kotaYangDikunjungi].jumlahMasyarakatTerinfeksi = Rumus.getJumlahMasyarakatTerinfeksi(nodes[kotaYangDikunjungi], sudahBerapaLamaTerinfeksi);
                foreach(TrailElement trailEl in nodes[kotaYangDikunjungi].trails)
                {
                    if(nodes[kotaYangDikunjungi].cekPenyebaranKe(trailEl.trail) > 1)
                    {
                        //rumus : hari kapan tersebar = floor(1/ (jmlmasyarakatterinfeksi_kota_asal * kemungkinan_travel_ke_tujuan)
                        int hariTersebar = ((int)(1 / nodes[kotaYangDikunjungi].jumlahMasyarakatTerinfeksi * trailEl.probability)) + 1;
                        if((hariTersebar < nodes[trailEl.trail].timeInfected) || (nodes[trailEl.trail].timeInfected == GraphElement.WAKTUMASYARAKATBELUMTERINFEKSI))
                        {
                            nodes[trailEl.trail].timeInfected = hariTersebar;
                            q.Enqueue(trailEl.trail);
                        }
                    }
                }
            }
        }
    }
}
