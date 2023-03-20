namespace Lab16Main
{
    public class XmlPrinter<T> : IPrinter<T> where T : ICloneable<T>, new()
    {
        public void Print(CycledList<T> list, Stream stream)
        {
            var serializer = new XmlSerializer(typeof(CycledList<T>));
            serializer.Serialize(stream, list);
        }
    }
}
