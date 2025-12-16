namespace EternalWoundsSaveOrganizer
{
    partial class SavestateEditNameWindow
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
            OKButton = new Button();
            label1 = new Label();
            SaveNameText = new TextBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.Location = new Point(37, 56);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Save name :";
            // 
            // SaveNameText
            // 
            SaveNameText.Location = new Point(12, 27);
            SaveNameText.Name = "SaveNameText";
            SaveNameText.Size = new Size(198, 23);
            SaveNameText.TabIndex = 2;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(118, 56);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SavestateEditNameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 90);
            Controls.Add(CancelButton);
            Controls.Add(SaveNameText);
            Controls.Add(label1);
            Controls.Add(OKButton);
            Name = "SavestateEditNameWindow";
            Text = "SavestateEditNameWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKButton;
        private Label label1;
        private TextBox SaveNameText;
        private Button CancelButton;
    }
}