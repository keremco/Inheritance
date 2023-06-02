using InheritanceDemo1.Services.Bases;

namespace InheritanceDemo1.Services
{
    class FileService : FileServiceBase
    {
        public FileService(string path) : base(path)
        {

        }
    }
}
