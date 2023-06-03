using InheritanceDemo1.Services;
using InheritanceDemo1.Services.Bases;

namespace InheritanceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C\DosyaOrnek\Öğrenciler.txt";
            FileServiceBase fs = new FileService(path);
            string content = fs.Read();

            //Console.WriteLine(content);

            //content += "\nMichael Jackson";
            //fs.Write(content);

            //Console.WriteLine(fs.Read());

            fs = new StreamService(path);
            content = fs.Read();
            Console.WriteLine(content);
        }
    }
}