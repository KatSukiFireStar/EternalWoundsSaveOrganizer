namespace EternalWoundsSaveOrganizer
{
    partial class MainWindow
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
            label1 = new Label();
            DropDownProfile = new ComboBox();
            ProfileButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile :";
            // 
            // DropDownProfile
            // 
            DropDownProfile.Location = new Point(71, 7);
            DropDownProfile.Name = "DropDownProfile";
            DropDownProfile.Size = new Size(308, 23);
            DropDownProfile.TabIndex = 1;
            // 
            // ProfileButton
            // 
            ProfileButton.Location = new Point(391, 7);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(95, 23);
            ProfileButton.TabIndex = 2;
            ProfileButton.Text = "Edit profile";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ControlDark;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(474, 349);
            listBox1.TabIndex = 4;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(listBox1);
            Controls.Add(ProfileButton);
            Controls.Add(DropDownProfile);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "Eternal Wounds Save Organizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox DropDownProfile;
        private Button ProfileButton;
        private ListBox listBox1;
    }
}
