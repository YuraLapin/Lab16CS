namespace Lab16Main
{
    [Serializable]
    [JsonDerivedType(typeof(Transport), typeDiscriminator: "transport")]
    [JsonDerivedType(typeof(Train), typeDiscriminator: "train")]
    [JsonDerivedType(typeof(Express), typeDiscriminator: "express")]
    public class Transport: ICloneable<Transport>
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Transport()
        {
            Name = "";
            Power = 0;
        }

        public Transport(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public Transport(Transport anotherTransport)
        {
            Name = anotherTransport.Name;
            Power = anotherTransport.Power;
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
            Name = sb.ToString();

            int maxPower = 1000;
            Power = Program.rand.Next(maxPower);
        }

        public override string ToString()
        {
            return GetType() + " name - " + Name.ToString() + " power - " + Power.ToString();
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
                return Equals(this.Name, transport.Name) && Equals(this.Power, transport.Power);
            }
            return false;
        }       

        public virtual Transport Clone()
        {
            return new Transport(this);
        }
    }
}