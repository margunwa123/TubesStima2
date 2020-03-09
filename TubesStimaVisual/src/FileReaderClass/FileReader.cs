using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubesStimaVisual.src.GraphClass;

namespace TubesStimaVisual.src.FileReaderClass
{
    abstract class TxtReader
    {
        protected string[] linesInFile;
        protected string path;
        public TxtReader(string path)
        {
            this.path = path;
            linesInFile = System.IO.File.ReadAllLines(path);
        }
        public int getNumber()
        {
            int number = (int)char.GetNumericValue(linesInFile[0][0]);
            return number;
        }
    }
}
