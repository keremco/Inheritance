using InheritanceDemo1.Services.Bases;
using System.Text;

namespace InheritanceDemo1.Services
{
    class StreamService : FileServiceBase
    {
        public StreamService(string path) : base(path)
        {

        }

        public override string Read()
        {
            StreamReader reader = new StreamReader(Path, Encoding.UTF8);

            return reader.ReadToEnd();
        }
    }
}
