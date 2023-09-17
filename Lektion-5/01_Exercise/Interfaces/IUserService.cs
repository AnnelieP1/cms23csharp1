using _01_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01_Exercise.Interfaces;

internal interface IUserService
{
    public void Create(UserCreateRequest userCreateRequest);
    public User Get(Expression<Func<User, bool>> expression);
    public IEnumerable<User> GetAll();
}
