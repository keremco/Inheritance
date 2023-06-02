using InheritanceDemo1.Services;

namespace InheritanceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C\DosyaOrnek\Öğrenciler.txt";
            FileService fs = new FileService(path);

            string content = fs.Read();
            Console.WriteLine(content);

            content += "\nMichael Jackson";
            fs.Write(content);

            Console.WriteLine(fs.Read());
        }
    }
}