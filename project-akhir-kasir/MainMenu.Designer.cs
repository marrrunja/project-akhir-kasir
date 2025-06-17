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
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // KasirBtn
            // 
            KasirBtn.Anchor = AnchorStyles.None;
            KasirBtn.Cursor = Cursors.Hand;
            KasirBtn.Location = new Point(359, 273);
            KasirBtn.Margin = new Padding(1, 2, 1, 2);
            KasirBtn.Name = "KasirBtn";
            KasirBtn.Size = new Size(239, 100);
            KasirBtn.TabIndex = 0;
            KasirBtn.Text = "Kasir";
            KasirBtn.UseVisualStyleBackColor = true;
            KasirBtn.Click += KasirBtn_Click;
            // 
            // ManageBarangBtn
            // 
            ManageBarangBtn.Anchor = AnchorStyles.None;
            ManageBarangBtn.Cursor = Cursors.Hand;
            ManageBarangBtn.Location = new Point(654, 273);
            ManageBarangBtn.Margin = new Padding(1, 2, 1, 2);
            ManageBarangBtn.Name = "ManageBarangBtn";
            ManageBarangBtn.Size = new Size(239, 100);
            ManageBarangBtn.TabIndex = 1;
            ManageBarangBtn.Text = "Manage Barang";
            ManageBarangBtn.UseVisualStyleBackColor = true;
            ManageBarangBtn.Click += ManageBarangBtn_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.Anchor = AnchorStyles.None;
            HistoryBtn.Cursor = Cursors.Hand;
            HistoryBtn.Location = new Point(943, 273);
            HistoryBtn.Margin = new Padding(1, 2, 1, 2);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(239, 100);
            HistoryBtn.TabIndex = 2;
            HistoryBtn.Text = "History Transaksi";
            HistoryBtn.UseVisualStyleBackColor = true;
            HistoryBtn.Click += HistoryBtn_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DodgerBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(207, 97);
            panel1.Margin = new Padding(1, 2, 1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 95);
            panel1.TabIndex = 3;
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
            label2.Location = new Point(813, 27);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(500, 27);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.DodgerBlue;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(320, 232);
            panel2.Margin = new Padding(1, 2, 1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 190);
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
            label3.Location = new Point(1127, 38);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1547, 835);
            Controls.Add(panel1);
            Controls.Add(HistoryBtn);
            Controls.Add(ManageBarangBtn);
            Controls.Add(KasirBtn);
            Controls.Add(panel2);
            Margin = new Padding(1, 2, 1, 2);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Utama";
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Label label3;
    }
}