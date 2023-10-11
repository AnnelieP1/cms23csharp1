using ActerGroup.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroup.Services;

public class ActerService
{
    private List<ActerMember> _actermembers = new List<ActerMember>();
    private readonly FileService _fileService = new FileService();
    public bool AddActerMemberToList(ActerMember actermember)
    {
        _actermembers.Add(actermember);
        FileService.SaveToFile(@"c:\Code\actermembers.json", JsonConvert.SerializeObject(_actermembers));
        return true;
    }

    public List<ActerMember> GetAllActerMembers()
    {
        var list = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(list))
        { 
            _actermembers = JsonConvert.DeserializeObject<List<ActerMember>>(list)!;

        }
        return _actermembers;
    }


    public void RemoveActerMember(string fullname)
    {
        var actermember = GetOneActerMember(fullname);
        _actermembers.Remove(actermember);
        FileService.SaveToFile(@"c:\Code\actermembers.json", JsonConvert.SerializeObject(_actermembers));
    }

    public ActerMember GetOneActerMember(string fullname)
    {
        return _actermembers.FirstOrDefault(x => x.FullName == fullname)!;
    }

}
