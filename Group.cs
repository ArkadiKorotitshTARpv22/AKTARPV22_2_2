using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Group
    {
        public List<string> Members { get; } = new List<string>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }
    public string PeopleList() 
    { 
        Random random= new Random();
        var peole = new List<string> { "Josh","John","Joseph","Jonathan","Arkadi","Luca","Alex","Kris","Jura","Artur","Egor","Anja","Aleksander","Oleksander","Dmitriy","Irina"};
        int chosenPerson = random.Next(peole.Count);
        return peole[chosenPerson];
    }
        public bool AddMember(string member)
        {
            if (Members.Contains(member)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(member);
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

