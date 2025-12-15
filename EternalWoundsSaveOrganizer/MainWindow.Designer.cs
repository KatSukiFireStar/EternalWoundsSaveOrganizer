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
            comboBox1 = new ComboBox();
            ProfileButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile :";
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(71, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 1;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Controls.Add(checkedListBox1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(8, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(478, 347);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(162, 418);
            checkedListBox1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ProfileButton);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "MainWindow";
            Text = "Eternal Wounds Save Organizer";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button ProfileButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckedListBox checkedListBox1;
    }
}
