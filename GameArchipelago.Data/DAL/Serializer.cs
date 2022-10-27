using GameArchipelago.Data.DAL.Interfaces;
using System.Xml.Serialization;

namespace GameArchipelago.Data.DAL
{
    public class Serializer<T> : ISerializer<T> where T : class, new()
    {
        private readonly string _filePath;

        public Serializer(string fileName)
            => _filePath = GetFilePath(fileName);

        private string GetFilePath(string fileName)
            => Path.Combine(Environment.CurrentDirectory, fileName);

        public IEnumerable<T> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var serializer = new XmlSerializer(typeof(List<T>));
            using var streamReader = new StreamReader(_filePath);

            var data = (List<T>) serializer.Deserialize(streamReader);
            streamReader.Close();
            return data;
        }

        public void SerializeToFile(IEnumerable<T> data)
        {
            var serializer = new XmlSerializer(typeof(List<T>));
            using var streamWriter = new StreamWriter(_filePath);

            serializer.Serialize(streamWriter, data);
            streamWriter.Close();
        }
    }
}
