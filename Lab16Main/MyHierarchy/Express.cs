namespace Lab16Main
{
    [Serializable]
    public class Express: Train
    {
        public List<string> StationsToSkip { get; set; }

        public Express(): base()
        {
            StationsToSkip = new List<string>();
        }

        public Express(string name, int power, int cars, List<string> stationsToSkip): base(name, power, cars)
        {
            StationsToSkip = stationsToSkip;
        } 
        
        public Express(Express anotherExpress): base(anotherExpress)
        {
            StationsToSkip = new List<string>(anotherExpress.StationsToSkip);
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
            Name = sb.ToString();

            int maxPower = 1000;
            Power = Program.rand.Next(maxPower);

            int maxCars = 9;
            Cars = Program.rand.Next(maxCars);

            int maxStations = 5;
            for (int i = 0; i < Program.rand.Next(maxStations); ++i)
            {
                StationsToSkip.Add("station" + i);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(GetType() + " name - " + Name.ToString() + ": power - " + Power.ToString() + ", cars - " + Cars.ToString() + ", list of stations to skip: [ ");
            if (StationsToSkip.Count > 0)
            {
                foreach (string s in StationsToSkip)
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