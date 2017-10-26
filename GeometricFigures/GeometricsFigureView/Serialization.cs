using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using GeometricFigures;
using Newtonsoft.Json;

namespace GeometricsFigureView
{
    public class Serialization
    {
        /*private static readonly BinaryFormatter _formatter = new BinaryFormatter();*/

        private static JsonSerializer _serializer = new JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };

        public static JsonSerializer SerialAccess
        {
            get { return _serializer; }
            set { _serializer = value; }
        }

        public static void Serializing(string fileName, List<IFigure> file)
        {
            using (var fs = new StreamWriter(fileName))
            {
                using (JsonWriter writer = new JsonTextWriter(fs))
                {
                    SerialAccess.Serialize(writer, file);
                }
            }
        }

        public static List<IFigure> Deserializing(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var file = (List<IFigure>) SerialAccess.Deserialize(reader, typeof (List<IFigure>));
                    return file;
                }           
            }
        }
    }
}
