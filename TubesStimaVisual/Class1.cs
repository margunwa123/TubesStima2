using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual
{
    class Rumus
    {
        public double getMasyarakatTerinfeksi(GraphElement graphelmt)
        {
            double fungsiLogistik = graphelmt.population;
            double denominator = 1 + (graphelmt.population - 1) * Math.Pow(2.718, -0.25 * (TxtReader.getNumber() - graphelmt.timeInfected));
            return fungsiLogistik / denominator;
        }

        public double getPenyebaranVirus(GraphElement graphelmt, int trailkeBerapa)
        {
            return getMasyarakatTerinfeksi(graphelmt) * graphelmt.trails[trailkeBerapa].probability;
        }
    }
}
