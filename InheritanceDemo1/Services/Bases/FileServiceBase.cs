namespace InheritanceDemo1.Services.Bases
{
    abstract class FileServiceBase
    {
        public string Path  { get; set; }

        public FileServiceBase(string path)
        {
            Path = path;
        }

        public string Read()
        {
            return File.ReadAllText(Path);
        }

        public void Write(string content)
        {
            File.WriteAllText(Path, content); 
        } 
    }
}

