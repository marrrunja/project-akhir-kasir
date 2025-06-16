namespace project_akhir_kasir
{
    partial class FormKasir
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
            txtKodeBarang = new TextBox();
            label1 = new Label();
            TambahBtn = new Button();
            label2 = new Label();
            QtyNumeric = new NumericUpDown();
            dgvBarangBeli = new DataGridView();
            GroupBoxPembelian = new GroupBox();
            label3 = new Label();
            CashNumeric = new NumericUpDown();
            BayarBtn = new Button();
            groupBox1 = new GroupBox();
            btnSelesai = new Button();
            btnCetak = new Button();
            KembalianTxt = new Label();
            KembalianLabel = new Label();
            TotalTxt = new Label();
            label4 = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)QtyNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarangBeli).BeginInit();
            GroupBoxPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashNumeric).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtKodeBarang
            // 
            txtKodeBarang.Location = new Point(221, 54);
            txtKodeBarang.Name = "txtKodeBarang";
            txtKodeBarang.Size = new Size(260, 39);
            txtKodeBarang.TabIndex = 0;
            txtKodeBarang.TextChanged += txtKodeBarang_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 58);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // TambahBtn
            // 
            TambahBtn.FlatStyle = FlatStyle.System;
            TambahBtn.Location = new Point(273, 201);
            TambahBtn.Name = "TambahBtn";
            TambahBtn.Size = new Size(172, 46);
            TambahBtn.TabIndex = 2;
            TambahBtn.Text = "Tambah";
            TambahBtn.UseVisualStyleBackColor = true;
            TambahBtn.Click += TambahBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 131);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 3;
            label2.Text = "Kuantitas";
            // 
            // QtyNumeric
            // 
            QtyNumeric.Location = new Point(221, 123);
            QtyNumeric.Name = "QtyNumeric";
            QtyNumeric.Size = new Size(260, 39);
            QtyNumeric.TabIndex = 4;
            QtyNumeric.ValueChanged += QtyNumeric_ValueChanged;
            // 
            // dgvBarangBeli
            // 
            dgvBarangBeli.BackgroundColor = Color.White;
            dgvBarangBeli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarangBeli.Location = new Point(32, 49);
            dgvBarangBeli.Name = "dgvBarangBeli";
            dgvBarangBeli.RowHeadersWidth = 82;
            dgvBarangBeli.Size = new Size(892, 266);
            dgvBarangBeli.TabIndex = 5;
            dgvBarangBeli.CellContentClick += dgvBarangBeli_CellContentClick;
            // 
            // GroupBoxPembelian
            // 
            GroupBoxPembelian.BackColor = Color.Transparent;
            GroupBoxPembelian.Controls.Add(txtKodeBarang);
            GroupBoxPembelian.Controls.Add(label1);
            GroupBoxPembelian.Controls.Add(TambahBtn);
            GroupBoxPembelian.Controls.Add(QtyNumeric);
            GroupBoxPembelian.Controls.Add(label2);
            GroupBoxPembelian.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBoxPembelian.ForeColor = Color.AliceBlue;
            GroupBoxPembelian.Location = new Point(30, 39);
            GroupBoxPembelian.Margin = new Padding(0);
            GroupBoxPembelian.Name = "GroupBoxPembelian";
            GroupBoxPembelian.Size = new Size(739, 282);
            GroupBoxPembelian.TabIndex = 7;
            GroupBoxPembelian.TabStop = false;
            GroupBoxPembelian.Text = "Pembelian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 134);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 8;
            label3.Text = "Cash";
            // 
            // CashNumeric
            // 
            CashNumeric.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashNumeric.Location = new Point(221, 133);
            CashNumeric.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            CashNumeric.Name = "CashNumeric";
            CashNumeric.Size = new Size(260, 39);
            CashNumeric.TabIndex = 5;
            // 
            // BayarBtn
            // 
            BayarBtn.BackColor = Color.DeepSkyBlue;
            BayarBtn.FlatStyle = FlatStyle.System;
            BayarBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BayarBtn.Location = new Point(536, 133);
            BayarBtn.Name = "BayarBtn";
            BayarBtn.Size = new Size(150, 41);
            BayarBtn.TabIndex = 9;
            BayarBtn.Text = "Bayar";
            BayarBtn.UseVisualStyleBackColor = false;
            BayarBtn.Click += BayarBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSelesai);
            groupBox1.Controls.Add(btnCetak);
            groupBox1.Controls.Add(KembalianTxt);
            groupBox1.Controls.Add(KembalianLabel);
            groupBox1.Controls.Add(TotalTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BayarBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CashNumeric);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.AliceBlue;
            groupBox1.Location = new Point(30, 380);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 337);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pembayaran";
            // 
            // btnSelesai
            // 
            btnSelesai.FlatStyle = FlatStyle.System;
            btnSelesai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSelesai.Location = new Point(413, 257);
            btnSelesai.Margin = new Padding(4);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(166, 52);
            btnSelesai.TabIndex = 15;
            btnSelesai.Text = "Selesai";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // btnCetak
            // 
            btnCetak.FlatStyle = FlatStyle.System;
            btnCetak.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCetak.Location = new Point(221, 257);
            btnCetak.Margin = new Padding(4);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(166, 52);
            btnCetak.TabIndex = 14;
            btnCetak.Text = "Cetak";
            btnCetak.UseVisualStyleBackColor = true;
            btnCetak.Click += btnCetak_Click;
            // 
            // KembalianTxt
            // 
            KembalianTxt.AutoSize = true;
            KembalianTxt.ImageAlign = ContentAlignment.BottomLeft;
            KembalianTxt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            KembalianTxt.Location = new Point(221, 207);
            KembalianTxt.Name = "KembalianTxt";
            KembalianTxt.RightToLeft = RightToLeft.No;
            KembalianTxt.Size = new Size(28, 32);
            KembalianTxt.TabIndex = 13;
            KembalianTxt.Text = "0";
            KembalianTxt.Click += KembalianTxt_Click;
            // 
            // KembalianLabel
            // 
            KembalianLabel.AutoSize = true;
            KembalianLabel.Location = new Point(43, 207);
            KembalianLabel.Name = "KembalianLabel";
            KembalianLabel.Size = new Size(135, 32);
            KembalianLabel.TabIndex = 12;
            KembalianLabel.Text = "Kembalian";
            // 
            // TotalTxt
            // 
            TotalTxt.AutoSize = true;
            TotalTxt.ImageAlign = ContentAlignment.BottomLeft;
            TotalTxt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            TotalTxt.Location = new Point(221, 67);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.RightToLeft = RightToLeft.No;
            TotalTxt.Size = new Size(28, 32);
            TotalTxt.TabIndex = 11;
            TotalTxt.Text = "0";
            TotalTxt.Click += TotalTxt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 67);
            label4.Name = "label4";
            label4.Size = new Size(77, 32);
            label4.TabIndex = 10;
            label4.Text = "Total ";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DodgerBlue;
            btnBack.FlatStyle = FlatStyle.System;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.AliceBlue;
            btnBack.Location = new Point(29, 18);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(247, 44);
            btnBack.TabIndex = 11;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1929, 82);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(dgvBarangBeli);
            panel2.Location = new Point(937, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 361);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(GroupBoxPembelian);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(91, 131);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(801, 776);
            panel3.TabIndex = 14;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8270297;
            ClientSize = new Size(1924, 997);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasir";
            Load += FormKasir_Load;
            ((System.ComponentModel.ISupportInitialize)QtyNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarangBeli).EndInit();
            GroupBoxPembelian.ResumeLayout(false);
            GroupBoxPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtKodeBarang;
        private Label label1;
        private Button TambahBtn;
        private Label label2;
        private NumericUpDown QtyNumeric;
        private DataGridView dgvBarangBeli;
        private GroupBox GroupBoxPembelian;
        private Label label3;
        private NumericUpDown CashNumeric;
        private Button BayarBtn;
        private GroupBox groupBox1;
        private Label TotalTxt;
        private Label label4;
        private Label KembalianTxt;
        private Label KembalianLabel;
        private Button btnBack;
        private Button btnCetak;
        private Button btnSelesai;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}