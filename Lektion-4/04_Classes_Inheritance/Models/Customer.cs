using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_Inheritance.Models;

internal class Customer
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime Created {  get; set; } = DateTime.Now;

    public DateTime Modified {  get; set; } = DateTime.Now;

}
