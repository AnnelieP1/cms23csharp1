using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AsyncAwait.Services
{
    internal class Menuservice
    {
        public record User(string Name, string Email);
        public static void AddUserMenu()
        {
            var user = new User("Annelie", "gydano1@hotmai.com");

            Console.WriteLine("Starting...");
            Console.WriteLine("Saving user to database");

            Task.Run(UserService.SaveUserAsync(User user));

            Console.WriteLine("Continue doing som work");
        }
    }
}
