using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class Train : Transport
    {
        public int cars;

        public Train() : base()
        {
            cars = 0;
        }

        public Train(string _name, int _maxSpeed, int _cars) : base(_name, _maxSpeed)
        {
            cars = _cars;
        }

        public Train(Train train): base (train)
        {
            cars = train.cars;
        }

        public override void RandomInit()
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

            int maxCars = 9;
            cars = Program.rand.Next(maxCars);
        }

        public override string ToString()
        {
            return GetType() + " name - " + name.ToString() + " power - " + power.ToString() + ", cars - " + cars.ToString();
        }

        //public override bool Equals(object? obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    if (obj is Train train)
        //    {
        //        return Equals(this.name, train.name) && Equals(this.power, train.power) && Equals(this.cars, train.cars);
        //    }
        //    return false;
        //}

        public override Train Clone()
        {
            return new Train(this);
        }
    }
}