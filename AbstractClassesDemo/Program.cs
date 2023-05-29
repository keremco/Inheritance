abstract class Kayit
{
    public int Id { get; set; }

    public string Guid { get; set; }
}

class Urun : Kayit
{ 

    public string Name { get; set; }


}

class Musteri : Kayit
{

    public string Name { get; set; }

    public string Surname { get; set; }
}