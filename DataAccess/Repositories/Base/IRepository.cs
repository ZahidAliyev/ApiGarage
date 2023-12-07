using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Base
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        
        Task<T> GetAsync(int id);
        Task Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
