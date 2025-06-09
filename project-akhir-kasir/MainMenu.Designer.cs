namespace project_akhir_kasir
{
    partial class MainMenu
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
            KasirBtn = new Button();
            ManageBarangBtn = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // KasirBtn
            // 
            KasirBtn.Location = new Point(195, 225);
            KasirBtn.Name = "KasirBtn";
            KasirBtn.Size = new Size(310, 128);
            KasirBtn.TabIndex = 0;
            KasirBtn.Text = "Kasir";
            KasirBtn.UseVisualStyleBackColor = true;
            // 
            // ManageBarangBtn
            // 
            ManageBarangBtn.Location = new Point(578, 225);
            ManageBarangBtn.Name = "ManageBarangBtn";
            ManageBarangBtn.Size = new Size(310, 128);
            ManageBarangBtn.TabIndex = 1;
            ManageBarangBtn.Text = "Manage Barang";
            ManageBarangBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(954, 225);
            button3.Name = "button3";
            button3.Size = new Size(310, 128);
            button3.TabIndex = 2;
            button3.Text = "##";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 819);
            Controls.Add(button3);
            Controls.Add(ManageBarangBtn);
            Controls.Add(KasirBtn);
            Name = "MainMenu";
            Text = "Menu Utama";
            Load += this.MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button KasirBtn;
        private Button ManageBarangBtn;
        private Button button3;
    }
}