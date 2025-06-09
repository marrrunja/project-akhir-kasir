using MySql.Data.MySqlClient;
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
    public partial class FormKasir : Form
    {
        class DetailItem
        {
            public int IdProdukInt { get; set; }
            public string IdProduk { get; set; }
            public int Jumlah { get; set; }
            public int Harga { get; set; }
            public int Total => Harga * Jumlah;
        }

        List<DetailItem> keranjang = new List<DetailItem>();
        int totalHarga = 0;

        public FormKasir()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Helper.backToHome(this);
        }

        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void QtyNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TambahBtn_Click(object sender, EventArgs e)
        {
            string kode = txtKodeBarang.Text.Trim();
            int qty = (int)QtyNumeric.Value;

            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                conn.Open();
                string query = "SELECT id, id_produk, nama_produk, harga FROM products WHERE id_produk = @kode";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kode", kode);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int idInt = reader.GetInt32("id");
                        string id = reader.GetString("id_produk");
                        string nama = reader.GetString("nama_produk");
                        int harga = reader.GetInt32("harga");
                        int subtotal = harga * qty;

                        // Tambah ke DataGridView
                        dgvBarangBeli.Rows.Add(id, nama, harga, qty, subtotal);


                        // Tambah ke keranjang list
                        keranjang.Add(new DetailItem
                        {
                            IdProdukInt = idInt,
                            IdProduk = id,
                            Jumlah = qty,
                            Harga = harga
                        });

                        // Update total
                        totalHarga += subtotal;
                        TotalTxt.Text = totalHarga.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan");
                    }
                }
            }
        }

        private void InitDataGridView()
        {
            dgvBarangBeli.Columns.Clear();
            dgvBarangBeli.Columns.Add("id", "ID Produk");
            dgvBarangBeli.Columns.Add("nama", "Nama Produk");
            dgvBarangBeli.Columns.Add("harga", "Harga");
            dgvBarangBeli.Columns.Add("qty", "Qty");
            dgvBarangBeli.Columns.Add("subtotal", "Subtotal");
        }

        private void dgvBarangBeli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotalTxt_Click(object sender, EventArgs e)
        {

        }
        private void BayarBtn_Click(object sender, EventArgs e)
        {
            int cash = Convert.ToInt32(CashNumeric.Value);

            if (keranjang.Count != 1)
            {
                MessageBox.Show("Transaksi hanya bisa untuk 1 produk!");
                return;
            }

            if (cash < totalHarga)
            {
                MessageBox.Show("Uang cash kurang!");
                return;
            }

            int kembalian = cash - totalHarga;
            KembalianTxt.Text = kembalian.ToString();

            var item = keranjang[0];

            if (Transaksi.InsertTransaksi(item.IdProdukInt, 1, item.Jumlah, item.Total) > 0)
            {
                MessageBox.Show("Pembayaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInput();
            }
            else
            {
                MessageBox.Show("Pembayaran gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearInput()
        {
          
            txtKodeBarang.Text = "";
            QtyNumeric.Value = 1;
            CashNumeric.Value = 0;
            KembalianTxt.Text = "";
            TotalTxt.Text = "0";
        
            dgvBarangBeli.Rows.Clear();

            keranjang.Clear();
            totalHarga = 0;
        }



        private void KembalianTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
