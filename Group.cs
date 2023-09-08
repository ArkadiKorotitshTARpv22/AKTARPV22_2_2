using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//"Josh","John","Joseph","Jonathan","Arkadi","Luca","Alex","Kris","Jura","Artur","Egor","Anja","Aleksander","Oleksander","Dmitriy","Irina"//
public class Group
{
    public List<string> Members { get; } = new List<string>();
    private readonly int _maxAmount;
    private Dictionary<string, int> _membersWithAge = new Dictionary<string, int>();

    public Group(int maxAmount)
    {
        _maxAmount = maxAmount;
    }

    public bool AddMember(string member, int age)
    {
        if (Members.Contains(member) || Members.Count >= _maxAmount)
            return false;

        Members.Add(member);
        _membersWithAge[member] = age;
        return true;
    }

    public int GetMembersCount()
    {
        return Members.Count;
    }

    public bool HasMember(string member)
    {
        return Members.Contains(member);
    }

   
}

