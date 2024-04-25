﻿namespace design
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            Picture4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameText = new TextBox();
            EmailText = new TextBox();
            PasswordText = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture4).BeginInit();
            SuspendLayout();
            // 
            // Picture4
            // 
            resources.ApplyResources(Picture4, "Picture4");
            Picture4.Name = "Picture4";
            Picture4.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Name = "label4";
            // 
            // NameText
            // 
            resources.ApplyResources(NameText, "NameText");
            NameText.BackColor = Color.FloralWhite;
            NameText.BorderStyle = BorderStyle.None;
            NameText.ForeColor = Color.DimGray;
            NameText.Name = "NameText";
            // 
            // EmailText
            // 
            resources.ApplyResources(EmailText, "EmailText");
            EmailText.BackColor = Color.FloralWhite;
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.ForeColor = Color.DimGray;
            EmailText.Name = "EmailText";
            // 
            // PasswordText
            // 
            resources.ApplyResources(PasswordText, "PasswordText");
            PasswordText.BackColor = Color.FloralWhite;
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.ForeColor = Color.DimGray;
            PasswordText.Name = "PasswordText";
            // 
            // EditButton
            // 
            resources.ApplyResources(EditButton, "EditButton");
            EditButton.BackColor = Color.FloralWhite;
            EditButton.ForeColor = Color.DimGray;
            EditButton.Name = "EditButton";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            resources.ApplyResources(SaveButton, "SaveButton");
            SaveButton.BackColor = Color.FloralWhite;
            SaveButton.ForeColor = Color.DimGray;
            SaveButton.Name = "SaveButton";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // Profile
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(PasswordText);
            Controls.Add(EmailText);
            Controls.Add(NameText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Picture4);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Profile";
            ((System.ComponentModel.ISupportInitialize)Picture4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
    }
}