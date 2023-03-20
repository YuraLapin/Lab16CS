using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public interface IPrinter<T> where T : ICloneable<T>, new()
    {
        void Print(CycledList<T> list, Stream stream);
    }
}
