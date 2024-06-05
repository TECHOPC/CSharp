using System.Data.SQLite;


internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Hi " + name);
    }
}