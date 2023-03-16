using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16Main
{
    public partial class ExpressAddForm : Form
    {
        public ExpressAddForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && powerTextBox.Text != "" && UserInteractor.IsInt(powerTextBox.Text) &&
                carsTextBox.Text != "" && UserInteractor.IsInt(carsTextBox.Text) && stationsTextBox.Text != ""
                && powerTextBox.Text.Count() <= 10 && carsTextBox.Text.Count() <= 10)
            {
                var stations = new List<string>(stationsTextBox.Lines);
                Program.list.Add(new Express(nameTextBox.Text, int.Parse(powerTextBox.Text), int.Parse(carsTextBox.Text), stations));
                this.Close();
            }
            else
            {
                var errorForm = new ErrorForm();
                errorForm.ShowDialog();
            }
        }
    }
}
