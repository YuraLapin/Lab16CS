namespace Lab16Main
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newTransportButton = new Button();
            randomTransportButton = new Button();
            newTrainButton = new Button();
            randomTrainButton = new Button();
            newExpressButton = new Button();
            randomExpressButton = new Button();
            binarySaveButton = new Button();
            binaryLoadButton = new Button();
            jsonSaveButton = new Button();
            jsonLoadButton = new Button();
            xmlSaveButton = new Button();
            xmlLoadButton = new Button();
            alterButtonsGroupBox = new GroupBox();
            alterButton = new Button();
            deleteButton = new Button();
            fileButtonsGroupBox = new GroupBox();
            collectionTextBox = new TextBox();
            filterGroupBox = new GroupBox();
            FilteringApplyButton = new Button();
            powerFilterTextBox = new TextBox();
            nameFilterTextBox = new TextBox();
            nothingFilterRadioButton = new RadioButton();
            powerFilterRadioButton = new RadioButton();
            nameFilterRadioButton = new RadioButton();
            sortingGroupBox = new GroupBox();
            nothingSortingRadioButton = new RadioButton();
            powerSortingRadioButton = new RadioButton();
            nameSortingRadioButton = new RadioButton();
            alterButtonsGroupBox.SuspendLayout();
            fileButtonsGroupBox.SuspendLayout();
            filterGroupBox.SuspendLayout();
            sortingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // newTransportButton
            // 
            newTransportButton.Location = new Point(15, 23);
            newTransportButton.Name = "newTransportButton";
            newTransportButton.Size = new Size(95, 23);
            newTransportButton.TabIndex = 1;
            newTransportButton.Text = "New Transport";
            newTransportButton.UseVisualStyleBackColor = true;
            newTransportButton.Click += newTransportButton_Click;
            // 
            // randomTransportButton
            // 
            randomTransportButton.Location = new Point(116, 23);
            randomTransportButton.Name = "randomTransportButton";
            randomTransportButton.Size = new Size(123, 23);
            randomTransportButton.TabIndex = 2;
            randomTransportButton.Text = "Random Transport";
            randomTransportButton.UseVisualStyleBackColor = true;
            randomTransportButton.Click += randomTransportButton_Click;
            // 
            // newTrainButton
            // 
            newTrainButton.Location = new Point(15, 52);
            newTrainButton.Name = "newTrainButton";
            newTrainButton.Size = new Size(95, 23);
            newTrainButton.TabIndex = 3;
            newTrainButton.Text = "New Train";
            newTrainButton.UseVisualStyleBackColor = true;
            newTrainButton.Click += newTrainButton_Click;
            // 
            // randomTrainButton
            // 
            randomTrainButton.Location = new Point(116, 52);
            randomTrainButton.Name = "randomTrainButton";
            randomTrainButton.Size = new Size(123, 23);
            randomTrainButton.TabIndex = 4;
            randomTrainButton.Text = "Random Train";
            randomTrainButton.UseVisualStyleBackColor = true;
            randomTrainButton.Click += randomTrainButton_Click;
            // 
            // newExpressButton
            // 
            newExpressButton.Location = new Point(15, 81);
            newExpressButton.Name = "newExpressButton";
            newExpressButton.Size = new Size(95, 23);
            newExpressButton.TabIndex = 5;
            newExpressButton.Text = "New Express";
            newExpressButton.UseVisualStyleBackColor = true;
            newExpressButton.Click += newExpressButton_Click;
            // 
            // randomExpressButton
            // 
            randomExpressButton.Location = new Point(116, 81);
            randomExpressButton.Name = "randomExpressButton";
            randomExpressButton.Size = new Size(123, 23);
            randomExpressButton.TabIndex = 6;
            randomExpressButton.Text = "Random Express";
            randomExpressButton.UseVisualStyleBackColor = true;
            randomExpressButton.Click += randomExpressButton_Click;
            // 
            // binarySaveButton
            // 
            binarySaveButton.Location = new Point(15, 22);
            binarySaveButton.Name = "binarySaveButton";
            binarySaveButton.Size = new Size(95, 23);
            binarySaveButton.TabIndex = 7;
            binarySaveButton.Text = "Save to Binary";
            binarySaveButton.UseVisualStyleBackColor = true;
            binarySaveButton.Click += binarySaveButton_Click;
            // 
            // binaryLoadButton
            // 
            binaryLoadButton.Location = new Point(116, 22);
            binaryLoadButton.Name = "binaryLoadButton";
            binaryLoadButton.Size = new Size(123, 23);
            binaryLoadButton.TabIndex = 8;
            binaryLoadButton.Text = "Load from Binary";
            binaryLoadButton.UseVisualStyleBackColor = true;
            binaryLoadButton.Click += binaryLoadButton_Click;
            // 
            // jsonSaveButton
            // 
            jsonSaveButton.Location = new Point(15, 52);
            jsonSaveButton.Name = "jsonSaveButton";
            jsonSaveButton.Size = new Size(95, 23);
            jsonSaveButton.TabIndex = 9;
            jsonSaveButton.Text = "Save to JSON";
            jsonSaveButton.UseVisualStyleBackColor = true;
            jsonSaveButton.Click += jsonSaveButton_Click;
            // 
            // jsonLoadButton
            // 
            jsonLoadButton.Location = new Point(116, 51);
            jsonLoadButton.Name = "jsonLoadButton";
            jsonLoadButton.Size = new Size(123, 23);
            jsonLoadButton.TabIndex = 10;
            jsonLoadButton.Text = "Load from JSON";
            jsonLoadButton.UseVisualStyleBackColor = true;
            jsonLoadButton.Click += jsonLoadButton_Click;
            // 
            // xmlSaveButton
            // 
            xmlSaveButton.Location = new Point(15, 81);
            xmlSaveButton.Name = "xmlSaveButton";
            xmlSaveButton.Size = new Size(95, 23);
            xmlSaveButton.TabIndex = 11;
            xmlSaveButton.Text = "Save to XML";
            xmlSaveButton.UseVisualStyleBackColor = true;
            xmlSaveButton.Click += xmlSaveButton_Click;
            // 
            // xmlLoadButton
            // 
            xmlLoadButton.Location = new Point(116, 81);
            xmlLoadButton.Name = "xmlLoadButton";
            xmlLoadButton.Size = new Size(123, 23);
            xmlLoadButton.TabIndex = 12;
            xmlLoadButton.Text = "Load from XML";
            xmlLoadButton.UseVisualStyleBackColor = true;
            xmlLoadButton.Click += xmlLoadButton_Click;
            // 
            // alterButtonsGroupBox
            // 
            alterButtonsGroupBox.Controls.Add(alterButton);
            alterButtonsGroupBox.Controls.Add(deleteButton);
            alterButtonsGroupBox.Controls.Add(newTransportButton);
            alterButtonsGroupBox.Controls.Add(randomTransportButton);
            alterButtonsGroupBox.Controls.Add(newTrainButton);
            alterButtonsGroupBox.Controls.Add(randomTrainButton);
            alterButtonsGroupBox.Controls.Add(newExpressButton);
            alterButtonsGroupBox.Controls.Add(randomExpressButton);
            alterButtonsGroupBox.Location = new Point(833, 19);
            alterButtonsGroupBox.Name = "alterButtonsGroupBox";
            alterButtonsGroupBox.Size = new Size(253, 143);
            alterButtonsGroupBox.TabIndex = 13;
            alterButtonsGroupBox.TabStop = false;
            alterButtonsGroupBox.Text = "Alter Collection";
            // 
            // alterButton
            // 
            alterButton.Location = new Point(15, 110);
            alterButton.Name = "alterButton";
            alterButton.Size = new Size(95, 23);
            alterButton.TabIndex = 8;
            alterButton.Text = "Alter Element";
            alterButton.UseVisualStyleBackColor = true;
            alterButton.Click += alterButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(116, 110);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(123, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete Element";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // fileButtonsGroupBox
            // 
            fileButtonsGroupBox.Controls.Add(binarySaveButton);
            fileButtonsGroupBox.Controls.Add(jsonLoadButton);
            fileButtonsGroupBox.Controls.Add(xmlLoadButton);
            fileButtonsGroupBox.Controls.Add(binaryLoadButton);
            fileButtonsGroupBox.Controls.Add(xmlSaveButton);
            fileButtonsGroupBox.Controls.Add(jsonSaveButton);
            fileButtonsGroupBox.Location = new Point(833, 313);
            fileButtonsGroupBox.Name = "fileButtonsGroupBox";
            fileButtonsGroupBox.Size = new Size(245, 119);
            fileButtonsGroupBox.TabIndex = 14;
            fileButtonsGroupBox.TabStop = false;
            fileButtonsGroupBox.Text = "File write/read";
            // 
            // collectionTextBox
            // 
            collectionTextBox.AcceptsReturn = true;
            collectionTextBox.AcceptsTab = true;
            collectionTextBox.Location = new Point(12, 19);
            collectionTextBox.Multiline = true;
            collectionTextBox.Name = "collectionTextBox";
            collectionTextBox.ReadOnly = true;
            collectionTextBox.ScrollBars = ScrollBars.Both;
            collectionTextBox.Size = new Size(805, 430);
            collectionTextBox.TabIndex = 15;
            collectionTextBox.WordWrap = false;
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(FilteringApplyButton);
            filterGroupBox.Controls.Add(powerFilterTextBox);
            filterGroupBox.Controls.Add(nameFilterTextBox);
            filterGroupBox.Controls.Add(nothingFilterRadioButton);
            filterGroupBox.Controls.Add(powerFilterRadioButton);
            filterGroupBox.Controls.Add(nameFilterRadioButton);
            filterGroupBox.Location = new Point(833, 184);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(181, 100);
            filterGroupBox.TabIndex = 16;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Filtering";
            // 
            // FilteringApplyButton
            // 
            FilteringApplyButton.Location = new Point(81, 70);
            FilteringApplyButton.Name = "FilteringApplyButton";
            FilteringApplyButton.Size = new Size(75, 23);
            FilteringApplyButton.TabIndex = 18;
            FilteringApplyButton.Text = "Apply";
            FilteringApplyButton.UseVisualStyleBackColor = true;
            FilteringApplyButton.Click += FilteringApplyButton_Click;
            // 
            // powerFilterTextBox
            // 
            powerFilterTextBox.Enabled = false;
            powerFilterTextBox.Location = new Point(69, 43);
            powerFilterTextBox.Name = "powerFilterTextBox";
            powerFilterTextBox.Size = new Size(100, 23);
            powerFilterTextBox.TabIndex = 4;
            // 
            // nameFilterTextBox
            // 
            nameFilterTextBox.Enabled = false;
            nameFilterTextBox.Location = new Point(69, 18);
            nameFilterTextBox.Name = "nameFilterTextBox";
            nameFilterTextBox.Size = new Size(100, 23);
            nameFilterTextBox.TabIndex = 3;
            // 
            // nothingFilterRadioButton
            // 
            nothingFilterRadioButton.AutoSize = true;
            nothingFilterRadioButton.Checked = true;
            nothingFilterRadioButton.Location = new Point(6, 72);
            nothingFilterRadioButton.Name = "nothingFilterRadioButton";
            nothingFilterRadioButton.Size = new Size(69, 19);
            nothingFilterRadioButton.TabIndex = 2;
            nothingFilterRadioButton.TabStop = true;
            nothingFilterRadioButton.Text = "Nothing";
            nothingFilterRadioButton.UseVisualStyleBackColor = true;
            nothingFilterRadioButton.Click += nothingFilterRadioButton_Click;
            // 
            // powerFilterRadioButton
            // 
            powerFilterRadioButton.AutoSize = true;
            powerFilterRadioButton.Location = new Point(6, 47);
            powerFilterRadioButton.Name = "powerFilterRadioButton";
            powerFilterRadioButton.Size = new Size(58, 19);
            powerFilterRadioButton.TabIndex = 1;
            powerFilterRadioButton.Text = "Power";
            powerFilterRadioButton.UseVisualStyleBackColor = true;
            powerFilterRadioButton.Click += powerFilterRadioButton_Click;
            // 
            // nameFilterRadioButton
            // 
            nameFilterRadioButton.AutoSize = true;
            nameFilterRadioButton.Location = new Point(6, 22);
            nameFilterRadioButton.Name = "nameFilterRadioButton";
            nameFilterRadioButton.Size = new Size(57, 19);
            nameFilterRadioButton.TabIndex = 0;
            nameFilterRadioButton.Text = "Name";
            nameFilterRadioButton.UseVisualStyleBackColor = true;
            nameFilterRadioButton.Click += nameFilterRadioButton_Click;
            // 
            // sortingGroupBox
            // 
            sortingGroupBox.Controls.Add(nothingSortingRadioButton);
            sortingGroupBox.Controls.Add(powerSortingRadioButton);
            sortingGroupBox.Controls.Add(nameSortingRadioButton);
            sortingGroupBox.Location = new Point(1033, 184);
            sortingGroupBox.Name = "sortingGroupBox";
            sortingGroupBox.Size = new Size(85, 100);
            sortingGroupBox.TabIndex = 17;
            sortingGroupBox.TabStop = false;
            sortingGroupBox.Text = "Sorting";
            // 
            // nothingSortingRadioButton
            // 
            nothingSortingRadioButton.AutoSize = true;
            nothingSortingRadioButton.Checked = true;
            nothingSortingRadioButton.Location = new Point(6, 72);
            nothingSortingRadioButton.Name = "nothingSortingRadioButton";
            nothingSortingRadioButton.Size = new Size(69, 19);
            nothingSortingRadioButton.TabIndex = 7;
            nothingSortingRadioButton.TabStop = true;
            nothingSortingRadioButton.Text = "Nothing";
            nothingSortingRadioButton.UseVisualStyleBackColor = true;
            nothingSortingRadioButton.Click += nothingSortingRadioButton_Click;
            // 
            // powerSortingRadioButton
            // 
            powerSortingRadioButton.AutoSize = true;
            powerSortingRadioButton.Location = new Point(6, 47);
            powerSortingRadioButton.Name = "powerSortingRadioButton";
            powerSortingRadioButton.Size = new Size(58, 19);
            powerSortingRadioButton.TabIndex = 6;
            powerSortingRadioButton.Text = "Power";
            powerSortingRadioButton.UseVisualStyleBackColor = true;
            powerSortingRadioButton.Click += powerSortingRadioButton_Click;
            // 
            // nameSortingRadioButton
            // 
            nameSortingRadioButton.AutoSize = true;
            nameSortingRadioButton.Location = new Point(6, 22);
            nameSortingRadioButton.Name = "nameSortingRadioButton";
            nameSortingRadioButton.Size = new Size(57, 19);
            nameSortingRadioButton.TabIndex = 5;
            nameSortingRadioButton.Text = "Name";
            nameSortingRadioButton.UseVisualStyleBackColor = true;
            nameSortingRadioButton.Click += nameSortingRadioButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 461);
            Controls.Add(sortingGroupBox);
            Controls.Add(filterGroupBox);
            Controls.Add(collectionTextBox);
            Controls.Add(fileButtonsGroupBox);
            Controls.Add(alterButtonsGroupBox);
            Name = "MainForm";
            Text = "Lab 16";
            Load += MainForm_Load;
            alterButtonsGroupBox.ResumeLayout(false);
            fileButtonsGroupBox.ResumeLayout(false);
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            sortingGroupBox.ResumeLayout(false);
            sortingGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button newTransportButton;
        private Button randomTransportButton;
        private Button newTrainButton;
        private Button randomTrainButton;
        private Button newExpressButton;
        private Button randomExpressButton;
        private Button binarySaveButton;
        private Button binaryLoadButton;
        private Button jsonSaveButton;
        private Button jsonLoadButton;
        private Button xmlSaveButton;
        private Button xmlLoadButton;
        private GroupBox alterButtonsGroupBox;
        private GroupBox fileButtonsGroupBox;
        private Button alterButton;
        private Button deleteButton;
        private TextBox collectionTextBox;
        private GroupBox filterGroupBox;
        private TextBox powerFilterTextBox;
        private TextBox nameFilterTextBox;
        private RadioButton nothingFilterRadioButton;
        private RadioButton powerFilterRadioButton;
        private RadioButton nameFilterRadioButton;
        private GroupBox sortingGroupBox;
        private RadioButton nothingSortingRadioButton;
        private RadioButton powerSortingRadioButton;
        private RadioButton nameSortingRadioButton;
        private Button FilteringApplyButton;
    }
}