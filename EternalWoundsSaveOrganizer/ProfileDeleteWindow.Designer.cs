namespace EternalWoundsSaveOrganizer
{
    partial class ProfileDeleteWindow
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
            ConfirmationLabel = new Label();
            YesButton = new Button();
            NoButton = new Button();
            SuspendLayout();
            // 
            // ConfirmationLabel
            // 
            ConfirmationLabel.AutoSize = true;
            ConfirmationLabel.Location = new Point(12, 9);
            ConfirmationLabel.Name = "ConfirmationLabel";
            ConfirmationLabel.Size = new Size(231, 15);
            ConfirmationLabel.TabIndex = 0;
            ConfirmationLabel.Text = "Are you sure you want to delete the profile";
            ConfirmationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // YesButton
            // 
            YesButton.Location = new Point(54, 55);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(75, 23);
            YesButton.TabIndex = 1;
            YesButton.Text = "Yes";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new Point(135, 55);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(75, 23);
            NoButton.TabIndex = 2;
            NoButton.Text = "No";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // ProfileDeleteWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 90);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(ConfirmationLabel);
            Name = "ProfileDeleteWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConfirmationLabel;
        private Button YesButton;
        private Button NoButton;
    }
}