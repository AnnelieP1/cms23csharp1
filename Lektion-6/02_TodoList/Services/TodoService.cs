using _02_TodoList.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TodoList.Services;

public class TodoService : ITodoService
{
    private List<ITodo> todos = new List<ITodo>();
    public bool AddTodo(ITodo todo)
    {
        try
        {
            todos.Add(todo);
            return true;
        }
        catch (Exception ex){ Debug.WriteLine(ex.Message); }
        return false;
    }

    public bool DeleteTodo(ITodo todo)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ITodo> GetAll()
    {
        try
        {
            return todos;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}
