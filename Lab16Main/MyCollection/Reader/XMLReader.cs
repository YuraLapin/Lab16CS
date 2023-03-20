using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class XmlReader<T> : IReader<T> where T : ICloneable<T>, new()
    {
        public CycledList<T> Read(CycledList<T> list, Stream stream)
        {
            var serializer = new XmlSerializer(typeof(CycledList<T>));
            CycledList<T>? newList = serializer.Deserialize(stream) as CycledList<T>;
            if (newList == null)
            {
                return new CycledList<T>();
            }
            return newList;
        }
    }
}
