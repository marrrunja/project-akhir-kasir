namespace project_akhir_kasir
{
    partial class ManageBarang
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
            groupBox3 = new GroupBox();
            cmbFilter = new ComboBox();
            txtFilter = new TextBox();
            btnCari = new Button();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dgvBarang = new DataGridView();
            groupBox1 = new GroupBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            label2 = new Label();
            txtNamaBarang = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnKembali = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            labelPage = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbFilter);
            groupBox3.Controls.Add(txtFilter);
            groupBox3.Controls.Add(btnCari);
            groupBox3.Location = new Point(19, 284);
            groupBox3.Margin = new Padding(1, 1, 1, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(1, 1, 1, 1);
            groupBox3.Size = new Size(390, 83);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cari Barang";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Nama", "Harga", "Stok", "Kode" });
            cmbFilter.Location = new Point(14, 18);
            cmbFilter.Margin = new Padding(1, 1, 1, 1);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(132, 23);
            cmbFilter.TabIndex = 16;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(162, 18);
            txtFilter.Margin = new Padding(1, 1, 1, 1);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(213, 23);
            txtFilter.TabIndex = 17;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(14, 46);
            btnCari.Margin = new Padding(1, 1, 1, 1);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(363, 22);
            btnCari.TabIndex = 18;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnHapus);
            groupBox2.Location = new Point(19, 203);
            groupBox2.Margin = new Padding(1, 1, 1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1, 1, 1, 1);
            groupBox2.Size = new Size(390, 68);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aksi";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(295, 26);
            btnClear.Margin = new Padding(1, 1, 1, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(10, 26);
            btnSimpan.Margin = new Padding(1, 1, 1, 1);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(80, 22);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(106, 26);
            btnEdit.Margin = new Padding(1, 1, 1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 22);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(202, 26);
            btnHapus.Margin = new Padding(1, 1, 1, 1);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(80, 22);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // dgvBarang
            // 
            dgvBarang.BackgroundColor = Color.AliceBlue;
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Location = new Point(17, 21);
            dgvBarang.Margin = new Padding(1, 1, 1, 1);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.RowHeadersWidth = 82;
            dgvBarang.Size = new Size(479, 294);
            dgvBarang.TabIndex = 21;
            dgvBarang.CellClick += dgvBarang_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStok);
            groupBox1.Controls.Add(txtHarga);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNamaBarang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(19, 14);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(390, 175);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(148, 113);
            txtStok.Margin = new Padding(1, 1, 1, 1);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(192, 23);
            txtStok.TabIndex = 7;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(148, 85);
            txtHarga.Margin = new Padding(1, 1, 1, 1);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(192, 23);
            txtHarga.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(148, 56);
            txtNamaBarang.Margin = new Padding(1, 1, 1, 1);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(192, 23);
            txtNamaBarang.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 86);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 113);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(16, 8);
            btnKembali.Margin = new Padding(2, 2, 2, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(133, 21);
            btnKembali.TabIndex = 8;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += button1_Click;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.Location = new Point(17, 330);
            btnPrev.Margin = new Padding(2, 2, 2, 2);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(109, 35);
            btnPrev.TabIndex = 24;
            btnPrev.Text = "Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(130, 330);
            btnNext.Margin = new Padding(2, 2, 2, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(109, 35);
            btnNext.TabIndex = 25;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPage.Location = new Point(12, 5);
            labelPage.Margin = new Padding(1, 0, 1, 0);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(114, 19);
            labelPage.TabIndex = 8;
            labelPage.Text = "Halaman 1 dari 2";
            labelPage.Click += labelPage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 38);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(50, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 387);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnPrev);
            panel3.Controls.Add(dgvBarang);
            panel3.Controls.Add(btnNext);
            panel3.Location = new Point(505, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 387);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(labelPage);
            panel4.Location = new Point(353, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 29);
            panel4.TabIndex = 26;
            // 
            // ManageBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources._8270297;
            ClientSize = new Size(1035, 519);
            Controls.Add(panel2);
            Controls.Add(btnKembali);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(1, 1, 1, 1);
            Name = "ManageBarang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Barang";
            Load += ManageBarang_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private ComboBox cmbFilter;
        private TextBox txtFilter;
        private Button btnCari;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private DataGridView dgvBarang;
        private GroupBox groupBox1;
        private TextBox txtStok;
        private TextBox txtHarga;
        private Label label2;
        private TextBox txtNamaBarang;
        private Label label3;
        private Label label4;
        private Button btnKembali;
        private Button btnPrev;
        private Button btnNext;
        private Label labelPage;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}