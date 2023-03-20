using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class XMLPrinter<T> : IPrinter<T> where T : ICloneable<T>, new()
    {
        public void Print(CycledList<T> list, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
