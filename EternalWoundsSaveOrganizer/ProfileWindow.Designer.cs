namespace EternalWoundsSaveOrganizer
{
    partial class ProfileWindow
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
            SaveLocation = new TextBox();
            BrowseSaveButton = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            BrowseProfileButton = new Button();
            label3 = new Label();
            NewProfileButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 7);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Savefile location :";
            // 
            // SaveLocation
            // 
            SaveLocation.BackColor = SystemColors.Window;
            SaveLocation.Enabled = false;
            SaveLocation.Location = new Point(14, 25);
            SaveLocation.Name = "SaveLocation";
            SaveLocation.Size = new Size(383, 23);
            SaveLocation.TabIndex = 1;
            // 
            // BrowseSaveButton
            // 
            BrowseSaveButton.Location = new Point(403, 25);
            BrowseSaveButton.Name = "BrowseSaveButton";
            BrowseSaveButton.Size = new Size(75, 23);
            BrowseSaveButton.TabIndex = 2;
            BrowseSaveButton.Text = "Browse";
            BrowseSaveButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 62);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Profile Directory :";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(14, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 4;
            // 
            // BrowseProfileButton
            // 
            BrowseProfileButton.Location = new Point(403, 80);
            BrowseProfileButton.Name = "BrowseProfileButton";
            BrowseProfileButton.Size = new Size(75, 23);
            BrowseProfileButton.TabIndex = 5;
            BrowseProfileButton.Text = "Browse";
            BrowseProfileButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Profiles:";
            // 
            // NewProfileButton
            // 
            NewProfileButton.Location = new Point(403, 148);
            NewProfileButton.Name = "NewProfileButton";
            NewProfileButton.Size = new Size(75, 23);
            NewProfileButton.TabIndex = 8;
            NewProfileButton.Text = "New";
            NewProfileButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(403, 177);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(403, 206);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ControlDark;
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Location = new Point(14, 148);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.ShowGroups = false;
            listView1.Size = new Size(383, 97);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // ProfileWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 261);
            Controls.Add(listView1);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(NewProfileButton);
            Controls.Add(label3);
            Controls.Add(BrowseProfileButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(BrowseSaveButton);
            Controls.Add(SaveLocation);
            Controls.Add(label1);
            Name = "ProfileWindow";
            Text = "Profile Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SaveLocation;
        private Button BrowseSaveButton;
        private Label label2;
        private TextBox textBox1;
        private Button BrowseProfileButton;
        private Label label3;
        private Button NewProfileButton;
        private Button EditButton;
        private Button DeleteButton;
        private ListView listView1;
    }
}