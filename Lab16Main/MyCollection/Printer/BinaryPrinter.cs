namespace Lab16Main
{
    public class BinaryPrinter<T>: IPrinter<T> where T: ICloneable<T>, new()
    {
        public void Print(CycledList<T> list, Stream stream)
        {
            var binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, list);
        }
    }
}
