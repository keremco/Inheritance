namespace InheritanceDemo1.Services.Bases
{
    abstract class FileServiceBase
    {
        public string Path  { get; set; }

        public FileServiceBase(string path)
        {
            Path = path;
        }

        public virtual string Read()
        {
            return File.ReadAllText(Path);
        }

        public virtual void Write(string content)
        {
            File.WriteAllText(Path, content); 
        } 
    }
}

