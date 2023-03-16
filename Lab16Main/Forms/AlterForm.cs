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
    public partial class AlterForm : Form
    {
        public AlterForm()
        {
            InitializeComponent();
        }

        private void alterTransportButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && powerTextBox.Text != "" && UserInteractor.IsInt(powerTextBox.Text) && powerTextBox.Text.Count() <= 10)
            {
                Program.list.Remove(new Transport(nameTextBox.Text, int.Parse(powerTextBox.Text)));
                var dialogueWindow = new TransportAddForm();
                dialogueWindow.ShowDialog();
                this.Close();
            }
            else
            {
                var errorForm = new ErrorForm();
                errorForm.ShowDialog();
            }
        }

        private void alterTrainButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && powerTextBox.Text != "" && UserInteractor.IsInt(powerTextBox.Text) && powerTextBox.Text.Count() <= 10)
            {
                Program.list.Remove(new Transport(nameTextBox.Text, int.Parse(powerTextBox.Text)));
                var dialogueWindow = new TrainAddForm();
                dialogueWindow.ShowDialog();
                this.Close();
            }
            else
            {
                var errorForm = new ErrorForm();
                errorForm.ShowDialog();
            }
        }

        private void alterExpressButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && powerTextBox.Text != "" && UserInteractor.IsInt(powerTextBox.Text) && powerTextBox.Text.Count() <= 10)
            {
                Program.list.Remove(new Transport(nameTextBox.Text, int.Parse(powerTextBox.Text)));
                var dialogueWindow = new ExpressAddForm();
                dialogueWindow.ShowDialog();
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
