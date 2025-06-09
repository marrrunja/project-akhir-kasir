using project_akhir_kasir.Config;
using project_akhir_kasir.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_akhir_kasir
{
    public partial class ManageBarang : Form
    {
        public ManageBarang()
        {
            InitializeComponent();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.backToHome(this);
        }

        private void loadData()
        {
            DataTable dt = Produk.getAllData();
            dgvBarang.DataSource = dt;
            dgvBarang.Columns["id"].HeaderText = "ID Produk";
            dgvBarang.Columns["id"].Visible = false;
            dgvBarang.Columns["id_produk"].HeaderText = "Kode Produk";
            dgvBarang.Columns["nama_produk"].HeaderText = "Nama Produk";
            dgvBarang.Columns["harga"].HeaderText = "Harga Produk";
            dgvBarang.Columns["stok"].HeaderText = "Stok";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clearInput()
        {
            txtNamaBarang.Text = "";
            txtHarga.Text = "";
            txtStok.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNamaBarang.Text;
            int harga = Convert.ToInt32(txtHarga.Text);
            int stok = Convert.ToInt32(txtStok.Text);
            if(Produk.insertData(nama, harga, stok) > 0)
            {
                MessageBox.Show("Berhasil insert produk", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInput();
            }
            else
            {
                MessageBox.Show("Gagal insert produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
