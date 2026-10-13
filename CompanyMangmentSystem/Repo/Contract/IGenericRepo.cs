namespace CompanyMangmentSystem.Repo.Contract
{
    public interface IGenericRepo<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> AddAsync(T item);
        void Update(T item);
        void Delete(int id);
    }
}
