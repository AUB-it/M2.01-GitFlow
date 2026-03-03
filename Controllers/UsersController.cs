using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Repository;
using UserAPI.Repository;
namespace UserAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    
    private readonly IUserRepository _userRepository;
    
    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    [HttpPost]
    [Route("register")]
    public IResult RegisterUser(User user)
    {
         _userRepository.RegisterUser(user);
        Console.WriteLine("User Registered");
        return Results.Created($"/api/users/{user.Id}", user);
    }

    [HttpPost]
    [Route("users/login")]
    public IResult Login(UserLogin loginRequest)
    {
        User? userExist = _userRepository.Login(loginRequest.username, loginRequest.password);
        if (userExist == null)
            return Results.Unauthorized();
        return Results.Ok(userExist);
    }
}

public record UserLogin(string username, string password);
