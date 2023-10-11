using _00_Repetition.Interfaces;
using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Services
{
    internal class TodoService : IToDoService
    {
        private readonly List<ToDo> _list = new List<ToDo>();
        public void Add(ToDo todo)
        {
            _list.Add(todo);
        }

        public void Delete(Guid id)
        {
            var todo = _list.FirstOrDefault(todo => todo.Id == id);
            if (todo != null) 
                _list.Remove(todo);
        }

        public IEnumerable<ToDo> GetAll()
        {
           return _list.OrderByDescending(todo => todo.Created);
        }
    }
}
