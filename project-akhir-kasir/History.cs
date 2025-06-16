using project_akhir_kasir.Config;
using project_akhir_kasir.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Printing;

namespace project_akhir_kasir
{
    public partial class History : Form
    {
        private int selectedId = -1;
        int pageSize = 7;
        int currentPage = 1;
        int totalPage = 1;
        int totalRecords = 0;
        bool isFiltered = false;
        public History()
        {
            InitializeComponent();
            //loadData();
            TampilkanDataDefault();

        }
        private void loadData()
        {
            try
            {
                dgvTransaksi.DataSource = HistoryPembelian.GetAllTransaksi();
                dgvTransaksi.Columns["ID Transaksi"].HeaderText = "ID Transaksi";
                dgvTransaksi.Columns["ID Produk"].HeaderText = "ID Produk";
                dgvTransaksi.Columns["Nama Barang"].HeaderText = "Nama Barang";
                dgvTransaksi.Columns["ID User"].HeaderText = "ID USER";
                dgvTransaksi.Columns["Tanggal Transaksi"].HeaderText = "Tanggal Transaksi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TampilkanDataDefault()
        {
            DataTable dt = HistoryPembelian.tampilkanDataDefault(ref totalRecords, ref totalPage, ref currentPage, ref pageSize);
            dgvTransaksi.DataSource = dt;
            labelPage.Text = $"Halaman {currentPage} dari {totalPage}";
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Helper.redirectTo(this, mainMenu);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            isFiltered = true;
            FilterData();
            labelPage.Text = "";
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
        private void FilterData()
        {
            string kolom = cmbFilter.SelectedItem?.ToString();
            string keyword = txtFilter.Text.Trim();

            if (string.IsNullOrEmpty(kolom)) return;
            dgvTransaksi.DataSource = HistoryPembelian.FilterTransaksi(kolom, keyword);

        }



        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                object valueSelectedId = row.Cells["ID Transaksi"].Value;
                selectedId = Convert.ToInt32(valueSelectedId);

                IdTransaksiTxt.Text = "" + selectedId;
                NamaTxt.Text = "" + row.Cells["Nama Barang"].Value?.ToString();
                TanggalTxt.Text = "" + row.Cells["Tanggal Transaksi"].Value?.ToString();

                var (jumlah, total, harga) = HistoryPembelian.GetDetailTransaksi(selectedId);
                JumlahPembelianTxt.Text = jumlah.ToString();
                TotalTxt.Text = total.ToString();
                HargaTxt.Text = harga.ToString();
            }
        }

        private void refreshForm()
        {
            txtFilter.Text = "";
            cmbFilter.SelectedIndex = -1;
            IdTransaksiTxt.Text = "-";
            NamaTxt.Text = "-";
            HargaTxt.Text = "-";
            JumlahPembelianTxt.Text = "-";
            TotalTxt.Text = "-";
            TanggalTxt.Text = "-";
            selectedId = -1;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            isFiltered = false;
            TampilkanDataDefault();
            refreshForm();
            btnNext.Enabled = true;
            btnPrev.Enabled = true;

        }

        private void filterDataWithTanggal()
        {
            string tanggalStr = filterTanggal.Value.ToString("yyyy-MM-dd");
            DataTable dt = HistoryPembelian.FilterTransaksiWithDate(tanggalStr);
            dgvTransaksi.DataSource = dt;

        }

        private void filterTanggal_ValueChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            totalPage = 1;
            filterDataWithTanggal();
            isFiltered = true;
            labelPage.Text = "";
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (isFiltered) FilterData();
                else TampilkanDataDefault();

                labelPage.Text = $"Halaman {currentPage} dari {totalPage}";

            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                if (isFiltered) FilterData();
                else TampilkanDataDefault();
                labelPage.Text = $"Halaman {currentPage} dari {totalPage}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
