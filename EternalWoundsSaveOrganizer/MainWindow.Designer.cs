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
            SaveList = new ListBox();
            Import = new Button();
            LoadButton = new Button();
            Replace = new Button();
            EditSaveName = new Button();
            Delete = new Button();
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
            ProfileButton.Location = new Point(385, 7);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(130, 23);
            ProfileButton.TabIndex = 2;
            ProfileButton.Text = "Edit profile";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // SaveList
            // 
            SaveList.BackColor = SystemColors.ControlDark;
            SaveList.FormattingEnabled = true;
            SaveList.ItemHeight = 15;
            SaveList.Location = new Point(12, 49);
            SaveList.Name = "SaveList";
            SaveList.Size = new Size(367, 199);
            SaveList.TabIndex = 4;
            // 
            // Import
            // 
            Import.Location = new Point(385, 49);
            Import.Name = "Import";
            Import.Size = new Size(130, 23);
            Import.TabIndex = 5;
            Import.Text = "Import savestate";
            Import.UseVisualStyleBackColor = true;
            Import.Click += Import_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(385, 78);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(130, 23);
            LoadButton.TabIndex = 6;
            LoadButton.Text = "Load savestate";
            LoadButton.UseVisualStyleBackColor = true;
            // 
            // Replace
            // 
            Replace.Location = new Point(385, 107);
            Replace.Name = "Replace";
            Replace.Size = new Size(130, 23);
            Replace.TabIndex = 7;
            Replace.Text = "Replace savestate";
            Replace.UseVisualStyleBackColor = true;
            // 
            // EditSaveName
            // 
            EditSaveName.Location = new Point(385, 136);
            EditSaveName.Name = "EditSaveName";
            EditSaveName.Size = new Size(130, 23);
            EditSaveName.TabIndex = 8;
            EditSaveName.Text = "Edit savestate name";
            EditSaveName.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(385, 165);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 23);
            Delete.TabIndex = 9;
            Delete.Text = "Delete savestate";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 274);
            Controls.Add(Delete);
            Controls.Add(EditSaveName);
            Controls.Add(Replace);
            Controls.Add(LoadButton);
            Controls.Add(Import);
            Controls.Add(SaveList);
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
        private ListBox SaveList;
        private Button Import;
        private Button LoadButton;
        private Button Replace;
        private Button EditSaveName;
        private Button Delete;
    }
}
