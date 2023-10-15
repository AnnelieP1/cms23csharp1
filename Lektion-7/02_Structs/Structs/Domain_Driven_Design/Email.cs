using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Structs.Structs.Domain_Driven_Design;

internal struct Email
{
    private readonly string value;

    public Email(string value)
    {
        
            this.value = value;
    }
}
