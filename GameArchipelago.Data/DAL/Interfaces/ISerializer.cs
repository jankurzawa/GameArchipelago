namespace GameArchipelago.Data.DAL.Interfaces
{
    public interface ISerializer<T> where T : class
    {
        void SerializeToFile(IEnumerable<T> data);
        IEnumerable<T> DeserializeFromFile();
    }
}
