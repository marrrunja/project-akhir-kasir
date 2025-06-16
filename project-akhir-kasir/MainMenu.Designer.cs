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
            HistoryBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // KasirBtn
            // 
            KasirBtn.Cursor = Cursors.Hand;
            KasirBtn.Location = new Point(150, 176);
            KasirBtn.Margin = new Padding(2);
            KasirBtn.Name = "KasirBtn";
            KasirBtn.Size = new Size(238, 100);
            KasirBtn.TabIndex = 0;
            KasirBtn.Text = "Kasir";
            KasirBtn.UseVisualStyleBackColor = true;
            KasirBtn.Click += KasirBtn_Click;
            // 
            // ManageBarangBtn
            // 
            ManageBarangBtn.Cursor = Cursors.Hand;
            ManageBarangBtn.Location = new Point(445, 176);
            ManageBarangBtn.Margin = new Padding(2);
            ManageBarangBtn.Name = "ManageBarangBtn";
            ManageBarangBtn.Size = new Size(238, 100);
            ManageBarangBtn.TabIndex = 1;
            ManageBarangBtn.Text = "Manage Barang";
            ManageBarangBtn.UseVisualStyleBackColor = true;
            ManageBarangBtn.Click += ManageBarangBtn_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.Cursor = Cursors.Hand;
            HistoryBtn.Location = new Point(734, 176);
            HistoryBtn.Margin = new Padding(2);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(238, 100);
            HistoryBtn.TabIndex = 2;
            HistoryBtn.Text = "History Transaksi";
            HistoryBtn.UseVisualStyleBackColor = true;
            HistoryBtn.Click += HistoryBtn_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 95);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Image = Properties.Resources.download;
            label2.Location = new Point(813, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(37, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 640);
            Controls.Add(panel1);
            Controls.Add(HistoryBtn);
            Controls.Add(ManageBarangBtn);
            Controls.Add(KasirBtn);
            Margin = new Padding(2);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Utama";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button KasirBtn;
        private Button ManageBarangBtn;
        private Button HistoryBtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}