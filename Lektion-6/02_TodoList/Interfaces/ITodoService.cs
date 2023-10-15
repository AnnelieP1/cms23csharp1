using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TodoList.Interfaces
{
    public interface ITodoService
    {
        bool AddTodo(ITodo todo);
        IEnumerable<ITodo> GetAll();

        bool DeleteTodo(ITodo todo);
    }
}