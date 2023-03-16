using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class Transport: ICloneable<Transport>
    {
        public string name;
        public int power;

        public Transport()
        {
            name = "";
            power = 0;
        }

        public Transport(string _name, int _power)
        {
            name = _name;
            power = _power;
        }

        public Transport(Transport transport)
        {
            name = transport.name;
            power = transport.power;
        }

        public virtual void RandomInit()
        {
            var sb = new StringBuilder();
            int nameSize = 5;
            string alphabet = "qwertyuiopasdfghjklzxcvbnm1234567890";
            for (int i = 0; i < nameSize; ++i)
            {
                sb.Append(alphabet[Program.rand.Next(alphabet.Length)]);
            }
            name = sb.ToString();

            int maxPower = 1000;
            power = Program.rand.Next(maxPower);
        }

        public override string ToString()
        {
            return GetType() + " name - " + name.ToString() + " power - " + power.ToString();
        }        

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Transport transport)
            {
                return Equals(this.name, transport.name) && Equals(this.power, transport.power);
            }
            return false;
        }       

        public virtual Transport Clone()
        {
            return new Transport(this);
        }
    }
}