namespace Football.Services
{
    public interface ICollectionService<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);

    }
}
