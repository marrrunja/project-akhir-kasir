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
            KembalianTxt = new Label();
            KembalianLabel = new Label();
            TotalTxt = new Label();
            label4 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)QtyNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarangBeli).BeginInit();
            GroupBoxPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashNumeric).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtKodeBarang
            // 
            txtKodeBarang.Location = new Point(221, 54);
            txtKodeBarang.Name = "txtKodeBarang";
            txtKodeBarang.Size = new Size(606, 39);
            txtKodeBarang.TabIndex = 0;
            txtKodeBarang.TextChanged += txtKodeBarang_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 58);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // TambahBtn
            // 
            TambahBtn.Location = new Point(343, 192);
            TambahBtn.Name = "TambahBtn";
            TambahBtn.Size = new Size(150, 46);
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
            label2.Size = new Size(112, 32);
            label2.TabIndex = 3;
            label2.Text = "Kuantitas";
            // 
            // QtyNumeric
            // 
            QtyNumeric.Location = new Point(221, 123);
            QtyNumeric.Name = "QtyNumeric";
            QtyNumeric.Size = new Size(240, 39);
            QtyNumeric.TabIndex = 4;
            QtyNumeric.ValueChanged += QtyNumeric_ValueChanged;
            // 
            // dgvBarangBeli
            // 
            dgvBarangBeli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarangBeli.Location = new Point(1014, 77);
            dgvBarangBeli.Name = "dgvBarangBeli";
            dgvBarangBeli.RowHeadersWidth = 82;
            dgvBarangBeli.Size = new Size(892, 868);
            dgvBarangBeli.TabIndex = 5;
            dgvBarangBeli.CellContentClick += dgvBarangBeli_CellContentClick;
            // 
            // GroupBoxPembelian
            // 
            GroupBoxPembelian.Controls.Add(txtKodeBarang);
            GroupBoxPembelian.Controls.Add(label1);
            GroupBoxPembelian.Controls.Add(TambahBtn);
            GroupBoxPembelian.Controls.Add(QtyNumeric);
            GroupBoxPembelian.Controls.Add(label2);
            GroupBoxPembelian.Location = new Point(22, 77);
            GroupBoxPembelian.Name = "GroupBoxPembelian";
            GroupBoxPembelian.Size = new Size(893, 282);
            GroupBoxPembelian.TabIndex = 7;
            GroupBoxPembelian.TabStop = false;
            GroupBoxPembelian.Text = "Pembelian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 134);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 8;
            label3.Text = "Cash";
            // 
            // CashNumeric
            // 
            CashNumeric.Location = new Point(221, 133);
            CashNumeric.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            CashNumeric.Name = "CashNumeric";
            CashNumeric.Size = new Size(240, 39);
            CashNumeric.TabIndex = 5;
            // 
            // BayarBtn
            // 
            BayarBtn.Location = new Point(536, 133);
            BayarBtn.Name = "BayarBtn";
            BayarBtn.Size = new Size(150, 41);
            BayarBtn.TabIndex = 9;
            BayarBtn.Text = "Bayar";
            BayarBtn.UseVisualStyleBackColor = true;
            BayarBtn.Click += BayarBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(KembalianTxt);
            groupBox1.Controls.Add(KembalianLabel);
            groupBox1.Controls.Add(TotalTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BayarBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CashNumeric);
            groupBox1.Location = new Point(22, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 337);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pembayaran";
            // 
            // KembalianTxt
            // 
            KembalianTxt.AutoSize = true;
            KembalianTxt.ImageAlign = ContentAlignment.BottomLeft;
            KembalianTxt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            KembalianTxt.Location = new Point(221, 207);
            KembalianTxt.Name = "KembalianTxt";
            KembalianTxt.RightToLeft = RightToLeft.No;
            KembalianTxt.Size = new Size(27, 32);
            KembalianTxt.TabIndex = 13;
            KembalianTxt.Text = "0";
            KembalianTxt.Click += KembalianTxt_Click;
            // 
            // KembalianLabel
            // 
            KembalianLabel.AutoSize = true;
            KembalianLabel.Location = new Point(43, 207);
            KembalianLabel.Name = "KembalianLabel";
            KembalianLabel.Size = new Size(126, 32);
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
            TotalTxt.Size = new Size(27, 32);
            TotalTxt.TabIndex = 11;
            TotalTxt.Text = "0";
            TotalTxt.Click += TotalTxt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 67);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 10;
            label4.Text = "Total ";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(25, 15);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(247, 44);
            btnBack.TabIndex = 11;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 997);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxPembelian);
            Controls.Add(dgvBarangBeli);
            Name = "FormKasir";
            Text = "Kasir";
            ((System.ComponentModel.ISupportInitialize)QtyNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarangBeli).EndInit();
            GroupBoxPembelian.ResumeLayout(false);
            GroupBoxPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}