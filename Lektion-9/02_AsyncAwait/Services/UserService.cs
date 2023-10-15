using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _02_AsyncAwait.Services.Menuservice;

namespace _02_AsyncAwait.Services;

internal class UserService
{
    public static async Task SaveUserAsync(User user)
    {
        Menuservice.AddUserMenu();
    }

}
