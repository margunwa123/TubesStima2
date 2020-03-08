using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual.src.GraphClass
{
    public class GraphElement
    {
        public char node;
        public int population;
        public int timeInfected;
        public bool isInfected;
        internal List<TrailElement> trails;
        public GraphElement(char node, int population, bool isInfected, int timeInfected)
        {
            trails = new List<TrailElement>();
            this.population = population;
            this.node = node;
            this.isInfected = isInfected;
            this.timeInfected = timeInfected;
        }
        public GraphElement(char node, int population) : this(node, population, false, -1) { }
        public GraphElement(char node) : this(node, 0) { }
        public void setKotaAwal()
        {
            timeInfected = 0;
            isInfected = true;
        }
        public void setInfectedTrue()
        {
            isInfected = true;
        }
    }
}
