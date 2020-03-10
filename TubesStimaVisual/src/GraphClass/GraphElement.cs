using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStimaVisual.src.GraphClass
{
    public class GraphElement
    {
        public const int WAKTUMASYARAKATBELUMTERINFEKSI = -1;

        public char node;
        public int population;
        public int timeInfected;
        public int jumlahMasyarakatTerinfeksi;
        internal List<TrailElement> trails;
        public GraphElement(char node, int population)
        {
            trails = new List<TrailElement>();
            this.population = population;
            this.node = node;
            this.timeInfected = WAKTUMASYARAKATBELUMTERINFEKSI;
            jumlahMasyarakatTerinfeksi = 0;
        }
        public GraphElement(char node) : this(node, 0) { }
        public double cekPenyebaranKe(char kotaLain)
        {
            int index = 0;
            for(int i = 0; i < trails.Count; i++)
            {
                if(trails[i].trail == kotaLain)
                {
                    index = i;
                    break;
                }
            }
            return (jumlahMasyarakatTerinfeksi * trails[index].probability);
        }
        public void setKotaAwal()
        {
            timeInfected = 0;
        }
    }
}
