using System.Threading.Tasks;
using aspnetcore.Models;
using System.Collections.Generic;

namespace aspnetcore.Data
{
    public interface IDatingRepository
    {
         void Add<T> (T entity) where T : class;
         void Delete <T> (T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}