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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && powerTextBox.Text != "" && UserInteractor.IsInt(powerTextBox.Text) && powerTextBox.Text.Count() <= 10)
            {
                Program.list.Remove(new Transport(nameTextBox.Text, int.Parse(powerTextBox.Text)));
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
