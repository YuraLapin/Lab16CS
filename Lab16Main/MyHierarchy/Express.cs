using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class Express: Train
    {
        public List<string> stationsToSkip;

        public Express(): base()
        {
            stationsToSkip = new List<string>();
        }

        public Express(string _name, int _maxSpeed, int _cars, List<string> _stationsToSkip): base(_name, _maxSpeed, _cars)
        {
            stationsToSkip = _stationsToSkip;
        } 
        
        public Express(Express express): base(express)
        {
            stationsToSkip = new List<string>(express.stationsToSkip);
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

            int maxStations = 5;
            for (int i = 0; i < Program.rand.Next(maxStations); ++i)
            {
                stationsToSkip.Add("station" + i);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(GetType() + " name - " + name.ToString() + ": power - " + power.ToString() + ", cars - " + cars.ToString() + ", list of stations to skip: [ ");
            if (stationsToSkip.Count > 0)
            {
                foreach (string s in stationsToSkip)
                {
                    sb.Append(s + ", ");
                }
                sb.Append("]");
            }
            else
            {
                sb.Append("- ]");
            }
            return GetType() + " " + sb.ToString();
        }

        //public override bool Equals(object? obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    if (obj is Express express)
        //    {
        //        return Equals(this.name, express.name) && Equals(this.power, express.power) && Equals(this.cars, express.cars) && Equals(this.stationsToSkip, express.stationsToSkip);
        //    }
        //    return false;
        //}

        public override Express Clone()
        {
            return new Express(this);
        }
    }
}