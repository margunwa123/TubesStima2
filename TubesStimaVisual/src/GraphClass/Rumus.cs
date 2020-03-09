using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual.src.GraphClass
{
    public partial class Graph
    {
        public double getMasyarakatTerinfeksi(char city)
        {
            GraphElement kotaYangDimaksud = nodes[IndexOf(city)];
            double fungsiLogistik = nodes[IndexOf(city)].population;
            double denominator = 1 + (fungsiLogistik - 1) * Math.Pow(Math.E, -0.25 * (size - kotaYangDimaksud.timeInfected));
            return fungsiLogistik / denominator;
        }

        public double getPenyebaranVirus(GraphElement graphelmt, int trailkeBerapa)
        {
            return getMasyarakatTerinfeksi(graphelmt.node) * graphelmt.trails[trailkeBerapa].probability;
        }
    }
}
