using GameArchipelago.Data.DAL.Interfaces;

namespace GameArchipelago.Data.DAL
{
    public class FileReader : IReader<string>
    {
        private readonly string _filePath;

        public FileReader(string fileName)
            => _filePath = GetFilePath(fileName);

        private string GetFilePath(string fileName)
            => Path.Combine(Environment.CurrentDirectory, fileName);

        public IEnumerable<string> GetDataFromFile()
            => new StreamReader(_filePath).ReadToEnd().Split('\n').Select(x => x.Replace("\r", ""));
    }
}
