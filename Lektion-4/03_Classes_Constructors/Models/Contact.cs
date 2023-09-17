using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes_Constructors.Models
{
    internal class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!; // null! = Ignorera varningsmeddelande men måste behandlas senare. 

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }


    }
}
