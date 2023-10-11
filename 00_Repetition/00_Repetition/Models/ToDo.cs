using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Models
{
    internal class ToDo
    {
        public Guid Id = Guid.NewGuid();
        public string Activity { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
