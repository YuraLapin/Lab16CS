using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class BinaryReader<T> : IReader<T> where T : ICloneable<T>, new()
    {
        public CycledList<T> Read(CycledList<T> list, Stream stream)
        {
            var binaryFormatter = new BinaryFormatter();
            CycledList<T> newList = (CycledList<T>)binaryFormatter.Deserialize(stream);
            if (newList == null)
            {
                return new CycledList<T>();
            }
            return newList;
        }
    }
}
