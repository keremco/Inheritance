
class Program
{
    static void Main(string[] args)
    {
        Database db = new SqlDatabase();
        db.Add();
        db = new MySqlDatabase();
        db.Delete();    
    }
}

abstract class Database
{
    public virtual void Add()
    {
        Console.WriteLine("Added by Database");
    }

    public virtual void Delete()
    {
        Console.WriteLine("Deleted by Database");
    }

    public void Update()
    {
        Console.WriteLine("Updated by Database");
    }

    public abstract void Drop();
}

class SqlDatabase : Database
{
    public override void Add()
    {
        Console.WriteLine("Added by SqlDatabase");
    }

    public override void Delete()
    {
        Console.WriteLine("Deleted by SqlDatabase");
    }

    public override void Drop()
    {
        throw new NotImplementedException();
    }
}

class MySqlDatabase : Database
{
    public override void Add()
    {
        Console.WriteLine("Added by MySqlDatabase");
    }

    public override void Delete()
    {
        Console.WriteLine("Deleted by MySqlDatabase");
    }

    public override void Drop()
    {
        throw new NotImplementedException();
    }
}