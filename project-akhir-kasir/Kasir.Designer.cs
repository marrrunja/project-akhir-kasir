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
            textBox1 = new TextBox();
            label1 = new Label();
            TambahBtn = new Button();
            label2 = new Label();
            QtyNumeric = new NumericUpDown();
            dgvBarang = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            GroupBoxPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CashNumeric).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 42);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 1;
            label1.Text = "Kode Barang";
            // 
            // TambahBtn
            // 
            TambahBtn.Location = new Point(264, 150);
            TambahBtn.Margin = new Padding(2);
            TambahBtn.Name = "TambahBtn";
            TambahBtn.Size = new Size(115, 36);
            TambahBtn.TabIndex = 2;
            TambahBtn.Text = "Tambah";
            TambahBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Kuantitas";
            // 
            // QtyNumeric
            // 
            QtyNumeric.Location = new Point(170, 96);
            QtyNumeric.Margin = new Padding(2);
            QtyNumeric.Name = "QtyNumeric";
            QtyNumeric.Size = new Size(185, 31);
            QtyNumeric.TabIndex = 4;
            // 
            // dgvBarang
            // 
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Location = new Point(780, 60);
            dgvBarang.Margin = new Padding(2);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.RowHeadersWidth = 82;
            dgvBarang.Size = new Size(686, 678);
            dgvBarang.TabIndex = 5;
            // 
            // GroupBoxPembelian
            // 
            GroupBoxPembelian.Controls.Add(textBox1);
            GroupBoxPembelian.Controls.Add(label1);
            GroupBoxPembelian.Controls.Add(TambahBtn);
            GroupBoxPembelian.Controls.Add(QtyNumeric);
            GroupBoxPembelian.Controls.Add(label2);
            GroupBoxPembelian.Location = new Point(17, 60);
            GroupBoxPembelian.Margin = new Padding(2);
            GroupBoxPembelian.Name = "GroupBoxPembelian";
            GroupBoxPembelian.Padding = new Padding(2);
            GroupBoxPembelian.Size = new Size(687, 220);
            GroupBoxPembelian.TabIndex = 7;
            GroupBoxPembelian.TabStop = false;
            GroupBoxPembelian.Text = "Pembelian";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 8;
            label3.Text = "Cash";
            // 
            // CashNumeric
            // 
            CashNumeric.Location = new Point(170, 104);
            CashNumeric.Margin = new Padding(2);
            CashNumeric.Name = "CashNumeric";
            CashNumeric.Size = new Size(185, 31);
            CashNumeric.TabIndex = 5;
            // 
            // BayarBtn
            // 
            BayarBtn.Location = new Point(412, 104);
            BayarBtn.Margin = new Padding(2);
            BayarBtn.Name = "BayarBtn";
            BayarBtn.Size = new Size(115, 32);
            BayarBtn.TabIndex = 9;
            BayarBtn.Text = "Bayar";
            BayarBtn.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(17, 310);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(697, 263);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pembayaran";
            // 
            // KembalianTxt
            // 
            KembalianTxt.AutoSize = true;
            KembalianTxt.ImageAlign = ContentAlignment.BottomLeft;
            KembalianTxt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            KembalianTxt.Location = new Point(170, 162);
            KembalianTxt.Margin = new Padding(2, 0, 2, 0);
            KembalianTxt.Name = "KembalianTxt";
            KembalianTxt.RightToLeft = RightToLeft.No;
            KembalianTxt.Size = new Size(22, 25);
            KembalianTxt.TabIndex = 13;
            KembalianTxt.Text = "0";
            // 
            // KembalianLabel
            // 
            KembalianLabel.AutoSize = true;
            KembalianLabel.Location = new Point(33, 162);
            KembalianLabel.Margin = new Padding(2, 0, 2, 0);
            KembalianLabel.Name = "KembalianLabel";
            KembalianLabel.Size = new Size(94, 25);
            KembalianLabel.TabIndex = 12;
            KembalianLabel.Text = "Kembalian";
            // 
            // TotalTxt
            // 
            TotalTxt.AutoSize = true;
            TotalTxt.ImageAlign = ContentAlignment.BottomLeft;
            TotalTxt.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            TotalTxt.Location = new Point(170, 52);
            TotalTxt.Margin = new Padding(2, 0, 2, 0);
            TotalTxt.Name = "TotalTxt";
            TotalTxt.RightToLeft = RightToLeft.No;
            TotalTxt.Size = new Size(22, 25);
            TotalTxt.TabIndex = 11;
            TotalTxt.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 52);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 10;
            label4.Text = "Total ";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 34);
            btnBack.TabIndex = 11;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 779);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxPembelian);
            Controls.Add(dgvBarang);
            Margin = new Padding(2);
            Name = "FormKasir";
            Text = "Kasir";
            ((System.ComponentModel.ISupportInitialize)QtyNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            GroupBoxPembelian.ResumeLayout(false);
            GroupBoxPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CashNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button TambahBtn;
        private Label label2;
        private NumericUpDown QtyNumeric;
        private DataGridView dgvBarang;
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