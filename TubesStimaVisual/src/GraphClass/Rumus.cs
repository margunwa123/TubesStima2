using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual.src.GraphClass
{
    class Rumus
    {
        private const double GAMMA = 0.25;

        public static int getJumlahMasyarakatTerinfeksi(GraphElement graphElement, int waktu)
        {
            if(graphElement.timeInfected == GraphElement.WAKTUMASYARAKATBELUMTERINFEKSI)
            {
                return 0;
            }
            else
            {
                double populasiGraph = graphElement.population;
                double denominator = 1 + ((populasiGraph - 1) * Math.Pow(Math.E, -(GAMMA * (waktu))));
                return (int) (populasiGraph / denominator);
            }
        }

        public static bool cekVirusMenyebar(int masyarakatTerinfeksi, double peluangPerjalanan)
        {
            return (masyarakatTerinfeksi * peluangPerjalanan >= 1);
        }

    }
}
