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
        public History()
        {
            InitializeComponent();
            loadData();

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

        private void btnKembali_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Helper.redirectTo(this, mainMenu);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            FilterData();
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
            refreshForm();
            loadData();
        }
    }
}
