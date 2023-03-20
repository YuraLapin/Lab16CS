using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class XMLReader<T> : IReader<T> where T : ICloneable<T>, new()
    {
        public CycledList<T> Read(CycledList<T> list, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
