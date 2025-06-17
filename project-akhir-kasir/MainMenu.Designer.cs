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
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // KasirBtn
            // 
            KasirBtn.Anchor = AnchorStyles.None;
            KasirBtn.Cursor = Cursors.Hand;
            KasirBtn.Location = new Point(257, 148);
            KasirBtn.Margin = new Padding(1);
            KasirBtn.Name = "KasirBtn";
            KasirBtn.Size = new Size(167, 60);
            KasirBtn.TabIndex = 0;
            KasirBtn.Text = "Kasir";
            KasirBtn.UseVisualStyleBackColor = true;
            KasirBtn.Click += KasirBtn_Click;
            // 
            // ManageBarangBtn
            // 
            ManageBarangBtn.Anchor = AnchorStyles.None;
            ManageBarangBtn.Cursor = Cursors.Hand;
            ManageBarangBtn.Location = new Point(464, 148);
            ManageBarangBtn.Margin = new Padding(1);
            ManageBarangBtn.Name = "ManageBarangBtn";
            ManageBarangBtn.Size = new Size(167, 60);
            ManageBarangBtn.TabIndex = 1;
            ManageBarangBtn.Text = "Manage Barang";
            ManageBarangBtn.UseVisualStyleBackColor = true;
            ManageBarangBtn.Click += ManageBarangBtn_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.Anchor = AnchorStyles.None;
            HistoryBtn.Cursor = Cursors.Hand;
            HistoryBtn.Location = new Point(666, 148);
            HistoryBtn.Margin = new Padding(1);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(167, 60);
            HistoryBtn.TabIndex = 2;
            HistoryBtn.Text = "History Transaksi";
            HistoryBtn.UseVisualStyleBackColor = true;
            HistoryBtn.Click += HistoryBtn_Click_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.DodgerBlue;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(230, 123);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 114);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Image = Properties.Resources.download;
            label3.Location = new Point(789, 23);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(150, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 418);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(350, 16);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Image = Properties.Resources.download;
            label2.Location = new Point(569, 16);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(151, 42);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 57);
            panel1.TabIndex = 3;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1083, 501);
            Controls.Add(panel1);
            Controls.Add(HistoryBtn);
            Controls.Add(ManageBarangBtn);
            Controls.Add(KasirBtn);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Utama";
            Load += MainMenu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button KasirBtn;
        private Button ManageBarangBtn;
        private Button HistoryBtn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}