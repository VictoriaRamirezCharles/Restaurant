using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class SerializationService 
    { 
   public void Serialize(object obj, string directory, string filename)
    {
        CreateDirectory(directory);
        IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(directory + "/" + filename, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, obj);
                stream.Close();
            };
    }

    public object Deserialize(string directory, string filename)
    {
        CreateDirectory(directory);
        object returno = null;
        if (File.Exists(directory + "/" + filename))
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(directory + "/" + filename, FileMode.Open, FileAccess.Read);
            returno = formatter.Deserialize(stream);
            stream.Close();
        }
        return returno;
    }

    private void CreateDirectory(string directory)
    {
        if (!Directory.Exists(directory))
        {
                Directory.CreateDirectory(directory);
            }
            else
            {
                Directory.CreateDirectory(directory);
            }
    }
}

}
