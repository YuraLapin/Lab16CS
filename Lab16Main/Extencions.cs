using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public static class Extensions
    {
        public static IEnumerable<T> Select<T>(this IEnumerable<T> col, Func<T, T> selector)
        {
            if (col == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                var res = new List<T>();
                foreach (T t in col)
                {
                    res.Add(selector(t));
                }
                return res;
            }
        }

        public static string ToString<T>(IEnumerable<T> collection)
        {
            var sb = new StringBuilder();
            sb.Append("[\r\n");
            if (collection.Count() == 0)
            {
                sb.Append("-\r\n");
            }
            else
            {
                foreach (T t in collection)
                {
                    sb.Append(t.ToString() + "\r\n");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }        
    }
}
