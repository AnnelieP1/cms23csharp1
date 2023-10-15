using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.Models;

public class Todo
{
    public string Activity { get; set; } = null!;
    public DateTime Created {  get; set; } = DateTime.Now;
}
