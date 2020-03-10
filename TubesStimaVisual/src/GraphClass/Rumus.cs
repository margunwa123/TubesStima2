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
            Console.WriteLine("timeinfected: " + graphElement.timeInfected);
            if(graphElement.timeInfected == GraphElement.WAKTUMASYARAKATBELUMTERINFEKSI)
            {
                return 0;
            }
            else
            {
                double populasiGraph = graphElement.population;
                Console.WriteLine("populasi graph : " + populasiGraph);
                double denominator = 1 + ((populasiGraph - 1) * Math.Pow(Math.E, -(GAMMA * (waktu))));
                Console.WriteLine("denominator : " + denominator);
                return (int) (populasiGraph / denominator);
            }
        }

        public static bool cekVirusMenyebar(int masyarakatTerinfeksi, double peluangPerjalanan)
        {
            return (masyarakatTerinfeksi * peluangPerjalanan >= 1);
        }
    }
}
