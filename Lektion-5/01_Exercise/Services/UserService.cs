using _01_Exercise.Interfaces;
using _01_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01_Exercise.Services;

internal class UserService : IUserService
{
    private List<User> _users = new List<User>();
    public void Create(UserCreateRequest userCreateRequest)
    {
        _users.Add(new User
        {
        Id = Guid.NewGuid(),
        FirstName = userCreateRequest.FirstName,
        LastName = userCreateRequest.LastName,
        Email = userCreateRequest.Email,
        });

        //Lösenordet får vi hantera separat, av säkerhetsskäl...
    }

    public User Get(Func <User, bool> expression)
    {
        var user = _users.FirstOrDefault(expression, null!);
        return user;            
    }

    public IEnumerable<User> GetAll()
    {
        return _users;
    }
}
