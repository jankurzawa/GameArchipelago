namespace GameArchipelago.Data.DAL.Interfaces
{
    public interface IReader<T>
    {
        IEnumerable<T> GetDataFromFile();
    }
}
