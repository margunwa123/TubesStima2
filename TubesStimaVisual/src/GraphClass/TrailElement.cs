using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual.src.GraphClass
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
}
