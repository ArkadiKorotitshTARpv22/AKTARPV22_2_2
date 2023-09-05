public class Program
{
    public static void Main()
    {
        Random random = new Random();
        Console.WriteLine("kui palju inimesi soovite grupiga liituda max:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("grupi nimi:");
        string n = Console.ReadLine();
        Group group = new Group(m);
        for (int i=0;i< random.Next(1, 1000); i++)
        {  
            Console.WriteLine(group.AddMember(group.PeopleList()));
        }
        Console.WriteLine("teie gruppi {0} kuuluvad:", n);
        Console.WriteLine(string.Join(", ", group.Members));
        Console.WriteLine(group.GetMembersCount());
        Console.WriteLine("-------------------------");

        Console.WriteLine("kui palju inimesi soovite grupiga liituda max:");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("grupi nimi:");
        string n2 = Console.ReadLine();
        Group group2 = new Group(m2);
        Console.WriteLine("kellega soovite liituda:");
        for (int i = 0; i < random.Next(1, 1000); i++)
        {
            Console.WriteLine(group.AddMember(group.PeopleList()));
        }

    }
}