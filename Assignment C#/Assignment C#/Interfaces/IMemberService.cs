using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_.Interfaces;

public interface IMemberService
{
    public void CreateMember(IMemberService memberService);
    public void AddMember();
    public void DeleteMember();

}
