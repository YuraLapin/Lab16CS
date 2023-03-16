namespace Lab16Main
{
    partial class DeleteForm
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
            submitButton = new Button();
            powerTextBox = new TextBox();
            powerLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(12, 134);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 9;
            submitButton.Text = "Delete";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // powerTextBox
            // 
            powerTextBox.Location = new Point(12, 91);
            powerTextBox.Name = "powerTextBox";
            powerTextBox.Size = new Size(272, 23);
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
            nameTextBox.Size = new Size(272, 23);
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
            // TransportDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 180);
            Controls.Add(submitButton);
            Controls.Add(powerTextBox);
            Controls.Add(powerLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "TransportDeleteForm";
            Text = "Delete Transport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private TextBox powerTextBox;
        private Label powerLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
    }
}