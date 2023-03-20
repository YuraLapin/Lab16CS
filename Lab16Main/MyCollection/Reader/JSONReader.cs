namespace Lab16Main
{
    public class JsonReader<T> : IReader<T> where T : ICloneable<T>, new()
    {
        public CycledList<T> Read(CycledList<T> list, Stream stream)
        {
            CycledList<T>? newList = JsonSerializer.Deserialize<CycledList<T>>(stream);
            if (newList == null)
            {
                return new CycledList<T>();
            }
            return newList;
        }
    }
}