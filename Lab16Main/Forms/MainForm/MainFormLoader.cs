using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Main
{
    public class MainFormLoader<T> where T : ICloneable<T>, new()
    {
        public void Load(MainForm form, CycledList<T> list, IReader<T> reader, string filter)
        {
            Stream stream;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    list.ReadFrom(reader, stream);
                    stream.Close();
                }
            }

            form.Updater.UpdateCollectionTextBox(form);
        }
    }
}
