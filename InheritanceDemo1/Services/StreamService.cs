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

            //yöntem 1
            //return reader.ReadToEnd();
            
            string result = "";

            //yöntem 2
            //while(!reader.EndOfStream) 
            //{ 
            //    result += reader.ReadLine() + "\n";
            //}

            //yöntem 3
            string line = reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                result += line; 
            }

            reader.Close();
            return result;
        }

        public override void Write(string content)
        {
            StreamWriter writer = new StreamWriter(Path, true, Encoding.UTF8);
            writer.WriteLine(content);

            writer.Close();
        }
    }
}
