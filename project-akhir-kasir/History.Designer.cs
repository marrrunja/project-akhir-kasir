namespace project_akhir_kasir
{
    partial class History
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
            btnKembali = new Button();
            dgvTransaksi = new DataGridView();
            groupBox3 = new GroupBox();
            cmbFilter = new ComboBox();
            txtFilter = new TextBox();
            btnCari = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            TotalTxt = new Label();
            JumlahPembelianTxt = new Label();
            TanggalTxt = new Label();
            HargaTxt = new Label();
            NamaTxt = new Label();
            IdTransaksiTxt = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            RefreshBtn = new Button();
            filterTanggal = new DateTimePicker();
            btnNext = new Button();
            btnPrev = new Button();
            labelPage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(52, 33);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(115, 36);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Location = new Point(52, 193);
            dgvTransaksi.Margin = new Padding(2);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.RowHeadersWidth = 82;
            dgvTransaksi.Size = new Size(686, 371);
            dgvTransaksi.TabIndex = 1;
            dgvTransaksi.CellClick += dgvTransaksi_CellClick;
            dgvTransaksi.CellContentClick += dgvTransaksi_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbFilter);
            groupBox3.Controls.Add(txtFilter);
            groupBox3.Controls.Add(btnCari);
            groupBox3.Location = new Point(52, 80);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1051, 85);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Transaksi";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "ID Transaksi", "Nama Barang", "Tanggal Transaksi" });
            cmbFilter.Location = new Point(18, 36);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(187, 33);
            cmbFilter.TabIndex = 16;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(218, 37);
            txtFilter.Margin = new Padding(2);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(311, 31);
            txtFilter.TabIndex = 17;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(552, 33);
            btnCari.Margin = new Padding(2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(125, 36);
            btnCari.TabIndex = 18;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 25;
            label1.Text = "ID Transaksi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(TotalTxt);
            groupBox1.Controls.Add(JumlahPembelianTxt);
            groupBox1.Controls.Add(TanggalTxt);
            groupBox1.Controls.Add(HargaTxt);
            groupBox1.Controls.Add(NamaTxt);
            groupBox1.Controls.Add(IdTransaksiTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(770, 193);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(524, 371);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Transaksi";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(211, 251);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(16, 25);
            label17.TabIndex = 41;
            label17.Text = ":";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(211, 209);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(16, 25);
            label16.TabIndex = 40;
            label16.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(211, 169);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(16, 25);
            label15.TabIndex = 39;
            label15.Text = ":";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(211, 127);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(16, 25);
            label14.TabIndex = 38;
            label14.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(211, 84);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(16, 25);
            label13.TabIndex = 37;
            label13.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(211, 42);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(16, 25);
            label12.TabIndex = 36;
            label12.Text = ":";
            // 
            // TotalTxt
            // 
            TotalTxt.AutoSize = true;
            TotalTxt.Location = new Point(230, 209);
            TotalTxt.Margin = new Padding(2, 0, 2, 0);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.Size = new Size(19, 25);
            TotalTxt.TabIndex = 35;
            TotalTxt.Text = "-";
            // 
            // JumlahPembelianTxt
            // 
            JumlahPembelianTxt.AutoSize = true;
            JumlahPembelianTxt.Location = new Point(230, 169);
            JumlahPembelianTxt.Margin = new Padding(2, 0, 2, 0);
            JumlahPembelianTxt.Name = "JumlahPembelianTxt";
            JumlahPembelianTxt.Size = new Size(19, 25);
            JumlahPembelianTxt.TabIndex = 34;
            JumlahPembelianTxt.Text = "-";
            // 
            // TanggalTxt
            // 
            TanggalTxt.AutoSize = true;
            TanggalTxt.Location = new Point(230, 251);
            TanggalTxt.Margin = new Padding(2, 0, 2, 0);
            TanggalTxt.Name = "TanggalTxt";
            TanggalTxt.Size = new Size(19, 25);
            TanggalTxt.TabIndex = 34;
            TanggalTxt.Text = "-";
            // 
            // HargaTxt
            // 
            HargaTxt.AutoSize = true;
            HargaTxt.Location = new Point(230, 127);
            HargaTxt.Margin = new Padding(2, 0, 2, 0);
            HargaTxt.Name = "HargaTxt";
            HargaTxt.Size = new Size(19, 25);
            HargaTxt.TabIndex = 33;
            HargaTxt.Text = "-";
            // 
            // NamaTxt
            // 
            NamaTxt.AutoSize = true;
            NamaTxt.Location = new Point(230, 84);
            NamaTxt.Margin = new Padding(2, 0, 2, 0);
            NamaTxt.Name = "NamaTxt";
            NamaTxt.Size = new Size(19, 25);
            NamaTxt.TabIndex = 32;
            NamaTxt.Text = "-";
            // 
            // IdTransaksiTxt
            // 
            IdTransaksiTxt.AutoSize = true;
            IdTransaksiTxt.Location = new Point(230, 42);
            IdTransaksiTxt.Margin = new Padding(2, 0, 2, 0);
            IdTransaksiTxt.Name = "IdTransaksiTxt";
            IdTransaksiTxt.Size = new Size(19, 25);
            IdTransaksiTxt.TabIndex = 31;
            IdTransaksiTxt.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 251);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 30;
            label6.Text = "Tanggal Transaksi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 127);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 29;
            label5.Text = "Harga Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 209);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 28;
            label4.Text = "Total Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 27;
            label3.Text = "Jumlah Pembelian\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 26;
            label2.Text = "Nama Barang";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(215, 33);
            RefreshBtn.Margin = new Padding(2);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(119, 36);
            RefreshBtn.TabIndex = 27;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // filterTanggal
            // 
            filterTanggal.Location = new Point(770, 113);
            filterTanggal.Name = "filterTanggal";
            filterTanggal.Size = new Size(300, 31);
            filterTanggal.TabIndex = 19;
            filterTanggal.ValueChanged += filterTanggal_ValueChanged;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(235, 583);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(156, 59);
            btnNext.TabIndex = 28;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(52, 583);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(156, 59);
            btnPrev.TabIndex = 29;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPage.Location = new Point(511, 604);
            labelPage.Margin = new Padding(2, 0, 2, 0);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(195, 32);
            labelPage.TabIndex = 30;
            labelPage.Text = "Halaman 1 dari 2";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 756);
            Controls.Add(labelPage);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(filterTanggal);
            Controls.Add(RefreshBtn);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(dgvTransaksi);
            Controls.Add(btnKembali);
            Margin = new Padding(2);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History Transaksi";
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private DataGridView dgvTransaksi;
        private GroupBox groupBox3;
        private ComboBox cmbFilter;
        private TextBox txtFilter;
        private Button btnCari;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label IdTransaksiTxt;
        private Label TotalTxt;
        private Label JumlahPembelianTxt;
        private Label TanggalTxt;
        private Label HargaTxt;
        private Label NamaTxt;
        private Label label13;
        private Label label12;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button RefreshBtn;
        private DateTimePicker filterTanggal;
        private Button btnNext;
        private Button btnPrev;
        private Label labelPage;
    }
}