using _00_Repetition.Interfaces;
using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Services
{
    internal class MenuService : IMenuService


    {

        private readonly IToDoService _todoService = new TodoService();

        public void AddMenu()
        {
            var todo = new ToDo();

            Console.Clear();
            Console.Write("Ange aktivitet: ");
            todo.Activity = Console.ReadLine()!;

            _todoService.Add(todo);


        }

        public void DeleteMenu()
        {
         Console.Clear();
         Console.Write("Ange Id: ");
         var id = Console.ReadLine()!;
            try
            {

                _todoService.Delete(new Guid(id));
            }
            catch { }

        }

        public void ListMenu()
        {
            {
                Console.Clear();
                Console.WriteLine("ATT-GÖRA-LISTAN");
                Console.WriteLine("---------------");

                foreach (var todo in _todoService.GetAll())
                {
                    Console.WriteLine($"{todo.Activity}");
                    Console.WriteLine($"{todo.Id} - {todo.Created}");
                    Console.WriteLine();

                }

                Console.ReadKey();

            }
        }

        public void MainMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("ATT-GÖRA-LISTAN");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Lägg till ny aktivitet");
                Console.WriteLine("2. Visa alla aktiviteter");
                Console.WriteLine("3. Ta bort en aktivitet");
                Console.Write("Ange ett av alternativen ovan: ");
                var option = Console.ReadLine()!;

                switch (option)
                {
                    case "1":
                        AddMenu();
                        break;
                    case "2":
                        ListMenu();
                        break;
                    case "3":
                        DeleteMenu();
                        break;
                }
            }
            while (true);
        }
    }

}
