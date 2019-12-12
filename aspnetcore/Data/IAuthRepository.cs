using System.Threading.Tasks;
using aspnetcore.Models;

namespace aspnetcore.Data
{
    public interface IAuthRepository
    {
         Task<user> Register(user user, string password);

         Task<user> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}