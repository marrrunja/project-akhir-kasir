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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            groupBox3.Text = "Transaksi";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "ID Transaksi", "Nama Barang", "Tanggal Transaksi" });
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
            label1.Size = new Size(139, 32);
            label1.TabIndex = 25;
            label1.Text = "ID Transaksi";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1158, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 417);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Transaksi";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(250, 323);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(245, 39);
            textBox6.TabIndex = 35;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(250, 268);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 39);
            textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(250, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 39);
            textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 39);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 39);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 39);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 321);
            label6.Name = "label6";
            label6.Size = new Size(198, 32);
            label6.TabIndex = 30;
            label6.Text = "Tanggal Transaksi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 163);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 29;
            label5.Text = "Harga Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 268);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 28;
            label4.Text = "Total Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 216);
            label3.Name = "label3";
            label3.Size = new Size(208, 32);
            label3.TabIndex = 27;
            label3.Text = "Jumlah Pembelian\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 108);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 26;
            label2.Text = "Nama Barang";
            label2.Click += label2_Click;
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
            Text = "History Transaksi";
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
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}