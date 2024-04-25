namespace design
{
    partial class CreateNewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewList));
            Picture5 = new PictureBox();
            Text1 = new Label();
            Text2 = new Label();
            Text3 = new Label();
            DescriptionCollectionText = new TextBox();
            CreateCollectionButton = new Button();
            CollectionNameText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Picture5).BeginInit();
            SuspendLayout();
            // 
            // Picture5
            // 
            resources.ApplyResources(Picture5, "Picture5");
            Picture5.Name = "Picture5";
            Picture5.TabStop = false;
            // 
            // Text1
            // 
            resources.ApplyResources(Text1, "Text1");
            Text1.BackColor = Color.Transparent;
            Text1.ForeColor = SystemColors.ButtonHighlight;
            Text1.Name = "Text1";
            // 
            // Text2
            // 
            resources.ApplyResources(Text2, "Text2");
            Text2.BackColor = Color.Transparent;
            Text2.ForeColor = SystemColors.ButtonHighlight;
            Text2.Name = "Text2";
            // 
            // Text3
            // 
            resources.ApplyResources(Text3, "Text3");
            Text3.BackColor = Color.Transparent;
            Text3.ForeColor = SystemColors.ButtonHighlight;
            Text3.Name = "Text3";
            // 
            // DescriptionCollectionText
            // 
            resources.ApplyResources(DescriptionCollectionText, "DescriptionCollectionText");
            DescriptionCollectionText.Name = "DescriptionCollectionText";
            // 
            // CreateCollectionButton
            // 
            resources.ApplyResources(CreateCollectionButton, "CreateCollectionButton");
            CreateCollectionButton.BackColor = Color.FloralWhite;
            CreateCollectionButton.ForeColor = Color.DimGray;
            CreateCollectionButton.Name = "CreateCollectionButton";
            CreateCollectionButton.UseVisualStyleBackColor = false;
            // 
            // CollectionNameText
            // 
            resources.ApplyResources(CollectionNameText, "CollectionNameText");
            CollectionNameText.Name = "CollectionNameText";
            // 
            // CreateNewList
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CollectionNameText);
            Controls.Add(CreateCollectionButton);
            Controls.Add(DescriptionCollectionText);
            Controls.Add(Text3);
            Controls.Add(Text2);
            Controls.Add(Text1);
            Controls.Add(Picture5);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "CreateNewList";
            ((System.ComponentModel.ISupportInitialize)Picture5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture5;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.TextBox DescriptionCollectionText;
        private System.Windows.Forms.Button CreateCollectionButton;
        private System.Windows.Forms.TextBox CollectionNameText;
    }
}