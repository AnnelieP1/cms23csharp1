using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Structs.Structs.Interoperability;

[StructLayout(LayoutKind.Sequential)]
public struct Todo
{
    public int userId;
    public int Id;
    public string title;
    public bool completed;
}

