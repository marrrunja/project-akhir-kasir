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
            groupBox3.Location = new Point(30, 509);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(557, 138);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cari Barang";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Judul", "Penulis", "Penerbit", "Tahun Terbit" });
            cmbFilter.Location = new Point(20, 30);
            cmbFilter.Margin = new Padding(2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(187, 33);
            cmbFilter.TabIndex = 16;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(237, 30);
            txtFilter.Margin = new Padding(2);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(303, 31);
            txtFilter.TabIndex = 17;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(20, 76);
            btnCari.Margin = new Padding(2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(519, 36);
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
            groupBox2.Location = new Point(30, 376);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(557, 114);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aksi";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(422, 44);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 36);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(14, 44);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(115, 36);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(151, 44);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 36);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(288, 44);
            btnHapus.Margin = new Padding(2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(115, 36);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // dgvBarang
            // 
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Location = new Point(652, 30);
            dgvBarang.Margin = new Padding(2);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.RowHeadersWidth = 82;
            dgvBarang.Size = new Size(684, 645);
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
            groupBox1.Location = new Point(30, 68);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(557, 292);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(211, 188);
            txtStok.Margin = new Padding(2);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(272, 31);
            txtStok.TabIndex = 7;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(211, 141);
            txtHarga.Margin = new Padding(2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(272, 31);
            txtHarga.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(211, 94);
            txtNamaBarang.Margin = new Padding(2);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(272, 31);
            txtNamaBarang.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 144);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(30, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 8;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += button1_Click;
            // 
            // ManageBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 695);
            Controls.Add(btnKembali);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvBarang);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
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