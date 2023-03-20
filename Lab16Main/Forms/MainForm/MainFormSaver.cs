namespace Lab16Main
{
    public class MainFormSaver<T> where T : ICloneable<T>, new()
    {
        public void Save(CycledList<T> list, IPrinter<T> printer, string filter)
        {
            Stream stream;
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    list.PrintTo(printer, stream);
                    stream.Close();
                }
            }
        }
    }
}