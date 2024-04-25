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
            Picture2.BackgroundImageLayout = ImageLayout.Center;
            Picture2.Image = (Image)resources.GetObject("Picture2.Image");
            Picture2.Location = new Point(-5, -4);
            Picture2.Margin = new Padding(3, 4, 3, 4);
            Picture2.Name = "Picture2";
            Picture2.Size = new Size(893, 809);
            Picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture2.TabIndex = 0;
            Picture2.TabStop = false;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.FloralWhite;
            RegistrationButton.BackgroundImageLayout = ImageLayout.None;
            RegistrationButton.FlatStyle = FlatStyle.Popup;
            RegistrationButton.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegistrationButton.ForeColor = Color.DimGray;
            RegistrationButton.Location = new Point(318, 650);
            RegistrationButton.Margin = new Padding(3, 4, 3, 4);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(269, 52);
            RegistrationButton.TabIndex = 5;
            RegistrationButton.Text = "Зарегистрироваться";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // NameRegText
            // 
            NameRegText.BackColor = Color.FloralWhite;
            NameRegText.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameRegText.ForeColor = Color.DimGray;
            NameRegText.Location = new Point(422, 339);
            NameRegText.Margin = new Padding(3, 4, 3, 4);
            NameRegText.Multiline = true;
            NameRegText.Name = "NameRegText";
            NameRegText.Size = new Size(305, 40);
            NameRegText.TabIndex = 6;
            // 
            // LoginRegText
            // 
            LoginRegText.BackColor = Color.FloralWhite;
            LoginRegText.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginRegText.ForeColor = Color.DimGray;
            LoginRegText.Location = new Point(422, 421);
            LoginRegText.Margin = new Padding(3, 4, 3, 4);
            LoginRegText.Multiline = true;
            LoginRegText.Name = "LoginRegText";
            LoginRegText.Size = new Size(305, 40);
            LoginRegText.TabIndex = 7;
            // 
            // PasswordRegText
            // 
            PasswordRegText.BackColor = Color.FloralWhite;
            PasswordRegText.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordRegText.ForeColor = Color.DimGray;
            PasswordRegText.Location = new Point(422, 501);
            PasswordRegText.Margin = new Padding(3, 4, 3, 4);
            PasswordRegText.Multiline = true;
            PasswordRegText.Name = "PasswordRegText";
            PasswordRegText.Size = new Size(305, 40);
            PasswordRegText.TabIndex = 8;
            PasswordRegText.KeyPress += PasswordRegText_KeyPress;
            // 
            // RegistrationWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 796);
            Controls.Add(PasswordRegText);
            Controls.Add(LoginRegText);
            Controls.Add(NameRegText);
            Controls.Add(RegistrationButton);
            Controls.Add(Picture2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationWindow";
            StartPosition = FormStartPosition.CenterScreen;
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