Customer customer = new Customer()
{
    Id = 1,
    Name = "Bıdı",
    Surname = "Budu",
    KartNo = "1234"
};

Console.WriteLine(customer.AdSoyadYazdir());

Person person2 = new Student()
{
    Department = "Yazılım"
};

//Console.WriteLine(((Student)person2).Department);   
Console.WriteLine((person2 as Student).Department);
class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string AdSoyadYazdir ()
    {
        return Name + " " + Surname;
    }
}

class Customer : Person
{
    public string KartNo { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}