using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual.src.FileReaderClass
{
    class GraphReader : TxtReader
    {
        public Dictionary<char, List<TrailElement>> connectionsAndProbability;
        public GraphReader(string path) : base(path)
        {
            connectionsAndProbability = new Dictionary<char, List<TrailElement>>();
            try { 
                for (int i = 1; i < linesInFile.Length; i++)
                {
                    char node = linesInFile[i][0];
                    char trail = linesInFile[i][2];
                    double probability = double.Parse(linesInFile[i].Substring(4));
                    TrailElement temp = new TrailElement(trail, probability);
                    if (connectionsAndProbability.ContainsKey(node))
                    {
                        connectionsAndProbability[node].Add(temp);
                    }
                    else
                    {
                        List<TrailElement> tempList = new List<TrailElement>();
                        tempList.Add(temp);
                        connectionsAndProbability.Add(node, tempList);
                    }
                }
            }
            catch (FormatException)
            {
                throw new FormatException("File Populasi yang anda masukan salah format");
            }
        }
    }

}
