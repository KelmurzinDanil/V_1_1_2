namespace design
{
    partial class RegistrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            Picture2 = new PictureBox();
            RegistrationButton = new Button();
            NameRegText = new TextBox();
            LoginRegText = new TextBox();
            PasswordRegText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Picture2).BeginInit();
            SuspendLayout();
            // 
            // Picture2
            // 
            resources.ApplyResources(Picture2, "Picture2");
            Picture2.Name = "Picture2";
            Picture2.TabStop = false;
            // 
            // RegistrationButton
            // 
            resources.ApplyResources(RegistrationButton, "RegistrationButton");
            RegistrationButton.BackColor = Color.FloralWhite;
            RegistrationButton.ForeColor = Color.DimGray;
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // NameRegText
            // 
            resources.ApplyResources(NameRegText, "NameRegText");
            NameRegText.BackColor = Color.FloralWhite;
            NameRegText.ForeColor = Color.DimGray;
            NameRegText.Name = "NameRegText";
            // 
            // LoginRegText
            // 
            resources.ApplyResources(LoginRegText, "LoginRegText");
            LoginRegText.BackColor = Color.FloralWhite;
            LoginRegText.ForeColor = Color.DimGray;
            LoginRegText.Name = "LoginRegText";
            // 
            // PasswordRegText
            // 
            resources.ApplyResources(PasswordRegText, "PasswordRegText");
            PasswordRegText.BackColor = Color.FloralWhite;
            PasswordRegText.ForeColor = Color.DimGray;
            PasswordRegText.Name = "PasswordRegText";
            PasswordRegText.KeyPress += PasswordRegText_KeyPress;
            // 
            // RegistrationWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PasswordRegText);
            Controls.Add(LoginRegText);
            Controls.Add(NameRegText);
            Controls.Add(RegistrationButton);
            Controls.Add(Picture2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "RegistrationWindow";
            ((System.ComponentModel.ISupportInitialize)Picture2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox NameRegText;
        private System.Windows.Forms.TextBox LoginRegText;
        private System.Windows.Forms.TextBox PasswordRegText;
    }
}