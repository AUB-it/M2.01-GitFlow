using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Repository;
// test
namespace UserAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    [HttpPost(Name = "RegisterUser")]
    public  User RegisterUser(User user)
    {
        throw new InvalidOperationException();
    }
}
