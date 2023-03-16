namespace Lab16Main
{
    partial class AlterForm
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
            alterTransportButton = new Button();
            powerTextBox = new TextBox();
            powerLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            alterTrainButton = new Button();
            alterExpressButton = new Button();
            SuspendLayout();
            // 
            // alterTransportButton
            // 
            alterTransportButton.Location = new Point(12, 134);
            alterTransportButton.Name = "alterTransportButton";
            alterTransportButton.Size = new Size(107, 23);
            alterTransportButton.TabIndex = 9;
            alterTransportButton.Text = "Alter to Transport";
            alterTransportButton.UseVisualStyleBackColor = true;
            alterTransportButton.Click += alterTransportButton_Click;
            // 
            // powerTextBox
            // 
            powerTextBox.Location = new Point(12, 91);
            powerTextBox.Name = "powerTextBox";
            powerTextBox.Size = new Size(309, 23);
            powerTextBox.TabIndex = 8;
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Location = new Point(12, 73);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new Size(43, 15);
            powerLabel.TabIndex = 7;
            powerLabel.Text = "Power:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(309, 23);
            nameTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // alterTrainButton
            // 
            alterTrainButton.Location = new Point(128, 134);
            alterTrainButton.Name = "alterTrainButton";
            alterTrainButton.Size = new Size(84, 23);
            alterTrainButton.TabIndex = 10;
            alterTrainButton.Text = "Alter to Train";
            alterTrainButton.UseVisualStyleBackColor = true;
            alterTrainButton.Click += alterTrainButton_Click;
            // 
            // alterExpressButton
            // 
            alterExpressButton.Location = new Point(218, 134);
            alterExpressButton.Name = "alterExpressButton";
            alterExpressButton.Size = new Size(103, 23);
            alterExpressButton.TabIndex = 11;
            alterExpressButton.Text = "Alter to Express";
            alterExpressButton.UseVisualStyleBackColor = true;
            alterExpressButton.Click += alterExpressButton_Click;
            // 
            // AlterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 180);
            Controls.Add(alterExpressButton);
            Controls.Add(alterTrainButton);
            Controls.Add(alterTransportButton);
            Controls.Add(powerTextBox);
            Controls.Add(powerLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "AlterForm";
            Text = "Alter Element";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button alterTransportButton;
        private TextBox powerTextBox;
        private Label powerLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Button alterTrainButton;
        private Button alterExpressButton;
    }
}