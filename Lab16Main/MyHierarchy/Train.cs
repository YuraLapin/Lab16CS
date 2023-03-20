namespace Lab16Main
{
    [Serializable]
    public class Train : Transport
    {
        public int Cars { get; set; }

        public Train() : base()
        {
            Cars = 0;
        }

        public Train(string name, int power, int cars) : base(name, power)
        {
            Cars = cars;
        }

        public Train(Train anotherTrain): base (anotherTrain)
        {
            Cars = anotherTrain.Cars;
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
        }

        public override string ToString()
        {
            return GetType() + " name - " + Name.ToString() + " power - " + Power.ToString() + ", cars - " + Cars.ToString();
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