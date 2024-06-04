using System.Data.SQLite;


internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Hi " + name + ", You are " + age + " years old");


        //save name and age to database using sqlite data.db
        //check if the table exists, if not create it
        using (var connection = new SQLiteConnection("Data Source=data.db"))    
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS People (name TEXT, age INTEGER)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO People VALUES(@name, @age)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.ExecuteNonQuery();
            }
        }
    }
}