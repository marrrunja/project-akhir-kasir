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
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            cmbFilter = new ComboBox();
            txtFilter = new TextBox();
            btnCari = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(68, 42);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(150, 46);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1022, 650);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cmbFilter);
            groupBox3.Controls.Add(txtFilter);
            groupBox3.Controls.Add(btnCari);
            groupBox3.Location = new Point(68, 103);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(892, 109);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cari Barang";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Judul", "Penulis", "Penerbit", "Tahun Terbit" });
            cmbFilter.Location = new Point(23, 46);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(242, 40);
            cmbFilter.TabIndex = 16;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(284, 47);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(403, 39);
            txtFilter.TabIndex = 17;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(717, 42);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(162, 46);
            btnCari.TabIndex = 18;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 25;
            label1.Text = "ID Transaksi:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1158, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 650);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Transaksi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 106);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 26;
            label2.Text = "Nama Produk:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 27;
            label3.Text = "Jumlah Pembelian:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 201);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 28;
            label4.Text = "Total Harga";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 968);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(btnKembali);
            Name = "History";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKembali;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private ComboBox cmbFilter;
        private TextBox txtFilter;
        private Button btnCari;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}