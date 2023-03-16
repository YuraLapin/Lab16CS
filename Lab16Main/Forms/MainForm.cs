using System.Linq;
using System.Text;

namespace Lab16Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateTextBox()
        {
            IEnumerable<Transport> ans;

            if (nameFilterRadioButton.Checked)
            {
                ans = from element in Program.list where element.name == nameFilterTextBox.Text select element;
            }
            else if (powerFilterRadioButton.Checked)
            {
                if (powerFilterTextBox.Text != "" && UserInteractor.IsInt(powerFilterTextBox.Text) && powerFilterTextBox.Text.Count() <= 10)
                {
                    ans = from element in Program.list where element.power == int.Parse(powerFilterTextBox.Text) select element;
                }
                else
                {
                    ans = new List<Transport>();
                }
            }
            else
            {
                ans = from element in Program.list select element;
            }

            if (nameSortingRadioButton.Checked)
            {
                ans = ans.OrderBy(element => element.name);
            }
            else if (powerSortingRadioButton.Checked)
            {
                ans = ans.OrderBy(element => element.power);
            }

            collectionTextBox.Text = Extensions.ToString(ans);
        }

        public void UpdateTextBox(Transport transport)
        {
            Program.list.Add(transport);
            UpdateTextBox();
        }

        private void newTransportButton_Click(object sender, EventArgs e)
        {
            var dialogueWindow = new TransportAddForm();
            dialogueWindow.ShowDialog();
            UpdateTextBox();
        }

        private void randomTransportButton_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            transport.RandomInit();
            UpdateTextBox(transport);
        }

        private void newTrainButton_Click(Object sender, EventArgs e)
        {
            var dialogueWindow = new TrainAddForm();
            dialogueWindow.ShowDialog();
            UpdateTextBox();
        }

        private void randomTrainButton_Click(object sender, EventArgs e)
        {
            var train = new Train();
            train.RandomInit();
            UpdateTextBox(train);
        }

        private void newExpressButton_Click(object sender, EventArgs e)
        {
            var dialogueWindow = new ExpressAddForm();
            dialogueWindow.ShowDialog();
            UpdateTextBox();
        }

        private void randomExpressButton_Click(object sender, EventArgs e)
        {
            var express = new Express();
            express.RandomInit();
            UpdateTextBox(express);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var dialogueWindow = new DeleteForm();
            dialogueWindow.ShowDialog();
            UpdateTextBox();
        }

        private void binarySaveButton_Click(object sender, EventArgs e)
        {

        }

        private void binaryLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void jsonSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void jsonLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void xmlSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void xmlLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void nameFilterRadioButton_Click(object sender, EventArgs e)
        {
            nameFilterTextBox.Enabled = true;

            powerFilterRadioButton.Checked = false;
            powerFilterTextBox.Enabled = false;

            nothingFilterRadioButton.Checked = false;
        }

        private void powerFilterRadioButton_Click(object sender, EventArgs e)
        {
            powerFilterTextBox.Enabled = true;

            nameFilterRadioButton.Checked = false;
            nameFilterTextBox.Enabled = false;

            nothingFilterRadioButton.Checked = false;
        }

        private void nothingFilterRadioButton_Click(object sender, EventArgs e)
        {
            nameFilterRadioButton.Checked = false;
            nameFilterTextBox.Enabled = false;

            powerFilterRadioButton.Checked = false;
            powerFilterTextBox.Enabled = false;
        }

        private void nameSortingRadioButton_Click(object sender, EventArgs e)
        {
            powerSortingRadioButton.Checked = false;
            nothingSortingRadioButton.Checked = false;
            UpdateTextBox();
        }

        private void powerSortingRadioButton_Click(object sender, EventArgs e)
        {
            nameSortingRadioButton.Checked = false;
            nothingSortingRadioButton.Checked = false;
            UpdateTextBox();
        }

        private void nothingSortingRadioButton_Click(object sender, EventArgs e)
        {
            nameSortingRadioButton.Checked = false;
            powerSortingRadioButton.Checked = false;
            UpdateTextBox();
        }

        private void FilteringApplyButton_Click(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void alterButton_Click(object sender, EventArgs e)
        {
            var dialogueWindow = new AlterForm();
            dialogueWindow.ShowDialog();
            UpdateTextBox();
        }
    }
}