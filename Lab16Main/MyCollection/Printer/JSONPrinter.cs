namespace Lab16Main
{
    public class JsonPrinter<T>: IPrinter<T> where T: ICloneable<T>, new()
    {
        public async void Print(CycledList<T> list, Stream stream)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            await JsonSerializer.SerializeAsync(stream, list, options);
            await stream.DisposeAsync();
        }
    }
}