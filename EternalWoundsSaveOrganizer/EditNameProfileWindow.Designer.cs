namespace EternalWoundsSaveOrganizer
{
    partial class EditNameProfileWindow
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
            label1 = new Label();
            ProfileNameText = new TextBox();
            OKButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile name :";
            // 
            // ProfileNameText
            // 
            ProfileNameText.Location = new Point(12, 27);
            ProfileNameText.Name = "ProfileNameText";
            ProfileNameText.Size = new Size(198, 23);
            ProfileNameText.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(30, 56);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(111, 56);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditNameProfileWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 90);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(ProfileNameText);
            Controls.Add(label1);
            Name = "EditNameProfileWindow";
            Text = "EditProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ProfileNameText;
        private Button OKButton;
        private new Button CancelButton;
    }
}