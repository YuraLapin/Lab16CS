namespace Lab16Main
{
    partial class ExpressAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carsTextBox = new TextBox();
            carsLabel = new Label();
            submitButton = new Button();
            powerTextBox = new TextBox();
            powerLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            stationsLabel = new Label();
            stationsTextBox = new TextBox();
            SuspendLayout();
            // 
            // carsTextBox
            // 
            carsTextBox.Location = new Point(12, 147);
            carsTextBox.Name = "carsTextBox";
            carsTextBox.Size = new Size(272, 23);
            carsTextBox.TabIndex = 18;
            // 
            // carsLabel
            // 
            carsLabel.AutoSize = true;
            carsLabel.Location = new Point(12, 129);
            carsLabel.Name = "carsLabel";
            carsLabel.Size = new Size(33, 15);
            carsLabel.TabIndex = 17;
            carsLabel.Text = "Cars:";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(12, 415);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 16;
            submitButton.Text = "Add";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // powerTextBox
            // 
            powerTextBox.Location = new Point(12, 91);
            powerTextBox.Name = "powerTextBox";
            powerTextBox.Size = new Size(272, 23);
            powerTextBox.TabIndex = 15;
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Location = new Point(12, 73);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new Size(43, 15);
            powerLabel.TabIndex = 14;
            powerLabel.Text = "Power:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(272, 23);
            nameTextBox.TabIndex = 13;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // stationsLabel
            // 
            stationsLabel.AutoSize = true;
            stationsLabel.Location = new Point(12, 183);
            stationsLabel.Name = "stationsLabel";
            stationsLabel.Size = new Size(91, 15);
            stationsLabel.TabIndex = 19;
            stationsLabel.Text = "Stations to Skip:";
            // 
            // stationsTextBox
            // 
            stationsTextBox.Location = new Point(12, 201);
            stationsTextBox.Multiline = true;
            stationsTextBox.Name = "stationsTextBox";
            stationsTextBox.ScrollBars = ScrollBars.Both;
            stationsTextBox.Size = new Size(272, 208);
            stationsTextBox.TabIndex = 20;
            // 
            // ExpressAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(stationsTextBox);
            Controls.Add(stationsLabel);
            Controls.Add(carsTextBox);
            Controls.Add(carsLabel);
            Controls.Add(submitButton);
            Controls.Add(powerTextBox);
            Controls.Add(powerLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "ExpressAddForm";
            Text = "Add Express";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox carsTextBox;
        private Label carsLabel;
        private Button submitButton;
        private TextBox powerTextBox;
        private Label powerLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label stationsLabel;
        private TextBox stationsTextBox;
    }
}