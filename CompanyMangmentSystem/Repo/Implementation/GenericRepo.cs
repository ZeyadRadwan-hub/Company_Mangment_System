using CompanyMangmentSystem.Data;
using CompanyMangmentSystem.Repo.Contract;
using Microsoft.EntityFrameworkCore;

namespace CompanyMangmentSystem.Repo.Implementation
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly App_Database_Context _db;
        public GenericRepo(App_Database_Context db)
        {
            _db = db;
        }

        public async Task<T> AddAsync(T item)
        {
            await _db.Set<T>().AddAsync(item);
            return item;
        }

        public void Delete(int id)
        {
            var s =  _db.Set<T>().Find(id);
            _db.Set<T>().Remove(s);
        }

        public async Task<T> Get(int id)
        {
            var res = await _db.Set<T>().FindAsync(id);
            return res;
        }

        public async Task<List<T>> GetAll()
        {
            var res = await _db.Set<T>().ToListAsync();
            return res;
        }

        public  void Update(T item)
        {
             _db.Set<T>().Update(item);
        }
    }
}
