using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Repository;

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