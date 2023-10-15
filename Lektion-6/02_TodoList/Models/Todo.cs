using _02_TodoList.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TodoList.Models
{
    public class Todo : ITodo
    {
        public Guid Id { get; set; }
        public string Activity { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
