public class Program
{
    public static void Main()
    {
        Random random = new Random();

        List<string> group1Members = new List<string>();
        List<string> group2Members = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            string name1 = RandomName(random);
            string name2 = RandomName(random);
            group1Members.Add(name1);
            group2Members.Add(name2);
        }

        
        Console.WriteLine("Group 1 inimesed, kes soovivad liituda:");
        PrintNames(group1Members);

        
        Console.WriteLine("\nGroup 2 inimesed, kes soovivad liituda:");
        PrintNames(group2Members);
        

        string groupName1 = RandomName(random);
        Console.WriteLine("\nmilline on maksimaalne:");
        int m = Convert.ToInt32(Console.ReadLine());
        int maxAmount1 = m;
        
        Group group1 = new Group(maxAmount1);
        Console.WriteLine($"\nGroup 1 maksimaalsed ruumid: {maxAmount1} ");

        string groupName2 = RandomName(random);
        Console.WriteLine("\nmilline on maksimaalne:");
        int m2 = Convert.ToInt32(Console.ReadLine());
        int maxAmount2 = m2;

        Group group2 = new Group(maxAmount2);
        Console.WriteLine($"Group 2 maksimaalsed ruumid: {maxAmount2}\n");
        

        for (int i = 0; i < maxAmount1; i++)
        {
            if (group1Members.Count > 0)
            {
                string memberName = group1Members[0];
                int age = random.Next(16, 60);
                group1.AddMember(memberName, age);
                group1Members.RemoveAt(0);
            }
        }

        for (int i = 0; i < maxAmount2; i++)
        {
            if (group2Members.Count > 0)
            {
                int randomIndex = random.Next(group2Members.Count);
                string memberName = group2Members[randomIndex];
                int age = random.Next(16, 60);
                group2.AddMember(memberName, age);
                group2Members.RemoveAt(randomIndex);
            }
        }
        
        Console.WriteLine($"Group 1 Successfully joined members: {string.Join(", ", group1.Members)}");
        Console.WriteLine($"Group 2 Successfully joined members: {string.Join(", ", group2.Members)}  \n");

        
    }

    public static void Shuffle<T>(IList<T> list, Random random)
    {
        int n = list.Count;
        for (int i = 0; i < n; i++)
        {
            int r = i + random.Next(n - i);
            T temp = list[i];
            list[i] = list[r];
            list[r] = temp;
        }
    }   
    public static void PrintNames(List<string> names)
    {
        HashSet<string> uniqueNames = new HashSet<string>();
        foreach (string name in names)
        {
            
            Console.Write($"{name}, ");
        }
        
        Console.WriteLine();
    }

    public static string RandomName(Random random)
    {
        string[] names = { "Josh", "John", "Joseph", "Jonathan", "Arkadi", "Luca", "Alex", "Kris", "Jura", "Artur", "Egor", "Anja", "Aleksander", "Oleksander", "Dmitriy", "Irina" };
        return names[random.Next(names.Length)];
    }
}