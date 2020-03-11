using System.IO;

namespace TubesStimaVisual.src.FileReaderClass
{
    abstract class TxtReader
    {
        protected string[] linesInFile;
        protected string path;
        public TxtReader(string path)
        {
            try
            {
                this.path = path;
                linesInFile = File.ReadAllLines(path);
            }
            catch(FileNotFoundException)
            {
                throw new FileNotFoundException("File dengan path \"" + path + "\" tidak ditemukan");
            }
        }
        public int getNumber()
        {
            int number = (int)char.GetNumericValue(linesInFile[0][0]);
            return number;
        }
    }
}
