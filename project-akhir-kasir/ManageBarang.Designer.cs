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
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbFilter);
            groupBox3.Controls.Add(txtFilter);
            groupBox3.Controls.Add(btnCari);
            groupBox3.Location = new Point(39, 652);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(724, 177);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cari Barang";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Judul", "Penulis", "Penerbit", "Tahun Terbit" });
            cmbFilter.Location = new Point(26, 38);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(242, 40);
            cmbFilter.TabIndex = 16;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(308, 38);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(393, 39);
            txtFilter.TabIndex = 17;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(26, 97);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(675, 46);
            btnCari.TabIndex = 18;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnSimpan);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnHapus);
            groupBox2.Location = new Point(39, 481);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(724, 146);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aksi";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(549, 56);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(152, 46);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(18, 56);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(150, 46);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(196, 56);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(374, 56);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(150, 46);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // dgvBarang
            // 
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Location = new Point(842, 36);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.RowHeadersWidth = 82;
            dgvBarang.Size = new Size(1020, 826);
            dgvBarang.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStok);
            groupBox1.Controls.Add(txtHarga);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNamaBarang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(39, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 374);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(274, 241);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(352, 39);
            txtStok.TabIndex = 7;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(274, 180);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(352, 39);
            txtHarga.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 120);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(274, 120);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(352, 39);
            txtNamaBarang.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 184);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 241);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(39, 15);
            btnKembali.Margin = new Padding(4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(146, 44);
            btnKembali.TabIndex = 8;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += button1_Click;
            // 
            // ManageBarang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 890);
            Controls.Add(btnKembali);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvBarang);
            Controls.Add(groupBox1);
            Name = "ManageBarang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Barang";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}