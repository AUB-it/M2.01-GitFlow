using UserAPI.Models;

namespace UserAPI.Repository;

public interface IUserRepository
{
    public User? Login(string username, string password);
}
