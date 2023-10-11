using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Interfaces;

internal interface IToDoService
{
    void Add(ToDo todo);

    IEnumerable<ToDo> GetAll();

    void Delete(Guid id);
}
