namespace Lab16Main
{
    partial class TransportAddForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            powerLabel = new Label();
            powerTextBox = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(27, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(27, 40);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(272, 23);
            nameTextBox.TabIndex = 1;
            // 
            // powerLabel
            // 
            powerLabel.AutoSize = true;
            powerLabel.Location = new Point(27, 86);
            powerLabel.Name = "powerLabel";
            powerLabel.Size = new Size(43, 15);
            powerLabel.TabIndex = 2;
            powerLabel.Text = "Power:";
            // 
            // powerTextBox
            // 
            powerTextBox.Location = new Point(27, 104);
            powerTextBox.Name = "powerTextBox";
            powerTextBox.Size = new Size(272, 23);
            powerTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(27, 147);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 4;
            submitButton.Text = "Add";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // TransportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 180);
            Controls.Add(submitButton);
            Controls.Add(powerTextBox);
            Controls.Add(powerLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "TransportForm";
            Text = "New Transport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label powerLabel;
        private TextBox powerTextBox;
        private Button submitButton;
    }
}