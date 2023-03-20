namespace Lab16Main
{
    public partial class MainForm : Form
    {
        public MainFormUpdater Updater;
        public MainFormSaver<Transport> Saver;
        public MainFormLoader<Transport> Loader;

        public MainForm()
        {
            Updater = new MainFormUpdater();
            Saver = new MainFormSaver<Transport>();
            Loader = new MainFormLoader<Transport>();
            InitializeComponent();
        }        

        public void UpdateTextBox(Transport transport)
        {
            Program.list.Add(transport);
            Updater.UpdateCollectionTextBox(this);
        }

        private void newTransportButton_Click(object sender, EventArgs e)
        {
            var dialogueWindow = new TransportAddForm();
            dialogueWindow.ShowDialog();
            Updater.UpdateCollectionTextBox(this);
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
            Updater.UpdateCollectionTextBox(this);
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
            Updater.UpdateCollectionTextBox(this);
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
            Updater.UpdateCollectionTextBox(this);
        }

        private void binarySaveButton_Click(object sender, EventArgs e)
        {            
            Saver.Save(Program.list, new BinaryPrinter<Transport>(), "bin files (*.bin)|*.bin");
        }

        private void binaryLoadButton_Click(object sender, EventArgs e)
        {
            Loader.Load(this, Program.list, new BinaryReader<Transport>(), "bin files (*.bin)|*.bin");
        }

        private void jsonSaveButton_Click(object sender, EventArgs e)
        {
            Saver.Save(Program.list, new JSONPrinter<Transport>(), "json files (*.json)|*.json");
        }

        private void jsonLoadButton_Click(object sender, EventArgs e)
        {
            Loader.Load(this, Program.list, new JSONReader<Transport>(), "json files (*.json)|*.json");
        }

        private void xmlSaveButton_Click(object sender, EventArgs e)
        {
            Saver.Save(Program.list, new XMLPrinter<Transport>(), "xml files (*.xml)|*.xml");
        }

        private void xmlLoadButton_Click(object sender, EventArgs e)
        {
            Loader.Load(this, Program.list, new XMLReader<Transport>(), "xml files (*.xml)|*.xml");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Updater.UpdateCollectionTextBox(this);
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
            Updater.UpdateCollectionTextBox(this);
        }

        private void powerSortingRadioButton_Click(object sender, EventArgs e)
        {
            nameSortingRadioButton.Checked = false;
            nothingSortingRadioButton.Checked = false;
            Updater.UpdateCollectionTextBox(this);
        }

        private void nothingSortingRadioButton_Click(object sender, EventArgs e)
        {
            nameSortingRadioButton.Checked = false;
            powerSortingRadioButton.Checked = false;
            Updater.UpdateCollectionTextBox(this);
        }

        private void FilteringApplyButton_Click(object sender, EventArgs e)
        {
            Updater.UpdateCollectionTextBox(this);
        }

        private void alterButton_Click(object sender, EventArgs e)
        {
            var dialogueWindow = new AlterForm();
            dialogueWindow.ShowDialog();
            Updater.UpdateCollectionTextBox(this);
        }
    }
}