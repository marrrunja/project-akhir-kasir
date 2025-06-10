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
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace project_akhir_kasir
{
    public partial class ManageBarang : Form
    {
        private int selectedId = -1;
        int pageSize = 2;
        int currentPage = 1;
        int totalPage = 1;
        int totalRecords = 0;
        bool isFiltered = false;
        public ManageBarang()
        {
            InitializeComponent();
            loadData();
            tampilkanDataDefault();
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

        private void clearForm()
        {
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            selectedId = -1;
            btnSimpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNamaBarang.Text;
            int harga = Convert.ToInt32(txtHarga.Text);
            int stok = Convert.ToInt32(txtStok.Text);
            if (Produk.insertData(nama, harga, stok) > 0)
            {
                MessageBox.Show("Berhasil insert produk", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                loadData();
            }
            else
            {
                MessageBox.Show("Gagal insert produk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            string nama = txtNamaBarang.Text;
            int harga = Convert.ToInt32(txtHarga.Text);
            int stok = Convert.ToInt32(txtStok.Text);
            if (Produk.updateData(selectedId, nama, harga, stok) > 0)
            {
                MessageBox.Show("Berhasil Update produk", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                loadData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data buku ini?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;
            if (Produk.hapusData(selectedId) > 0)
            {
                MessageBox.Show("Data produk berhasil dihapus.");
                loadData();
                clearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
        private void FilterData()
        {

        }
        private void tampilkandataFiltered()
        {
            string kolom = cmbFilter.SelectedItem?.ToString();
            string keyword = txtFilter.Text.Trim();
            string kolomDB = "nama_produk";

            if (kolom == "Stok") kolomDB = "stok";
            else if (kolom == "harga") kolomDB = "harga";
            else if (kolom == "Kode") kolomDB = "id_produk";

            DataTable dt = Produk.searchData(kolomDB, keyword);
            dgvBarang.DataSource = dt;
        }
        private void tampilkanDataDefault()
        {
            DataTable dt = Produk.tampilkanDataDefault(ref totalRecords, ref totalPage, ref currentPage, ref pageSize);
            labelPage.Text = $"Halaman {currentPage} dari {totalPage}";
            dgvBarang.DataSource = dt;
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            tampilkandataFiltered();
            currentPage = 1;
            isFiltered = true;
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valueSelectedId = dgvBarang.Rows[e.RowIndex].Cells["id"].Value?.ToString() ?? "";
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value)
                    ? Convert.ToInt32(valueSelectedId)
                    : -1;

                txtNamaBarang.Text = dgvBarang.Rows[e.RowIndex].Cells["nama_produk"].Value?.ToString() ?? "";
                txtHarga.Text = dgvBarang.Rows[e.RowIndex].Cells["harga"].Value?.ToString() ?? "";
                txtStok.Text = dgvBarang.Rows[e.RowIndex].Cells["stok"].Value?.ToString() ?? "";
                btnSimpan.Enabled = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
     
            if (currentPage > 1)
            {
                currentPage--;
                if (isFiltered == true) tampilkandataFiltered();
                else tampilkanDataDefault();
              
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentPage < totalPage)
            {
                currentPage++;
                if (isFiltered) tampilkandataFiltered();
                else tampilkanDataDefault();
            }
        }
    }
}
