using System;
using project_akhir_kasir.Config;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.VisualBasic.Devices;
using System.Collections;

namespace project_akhir_kasir.Model
{
    class HistoryPembelian
    {
        public static DataTable GetAllTransaksi()
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                string query = @"
                    SELECT 
                        transaksi.id AS `ID Transaksi`,
                        transaksi.id_produk AS `ID Produk`,
                        products.nama_produk AS `Nama Barang`,
                        transaksi.id_user AS `ID User`,
                        transaksi.tanggal_transaksi AS `Tanggal Transaksi`
                    FROM 
                        transaksi
                    JOIN 
                        products ON transaksi.id_produk = products.id
                    ORDER BY 
                        transaksi.id DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable FilterTransaksi(string kolom, string keyword)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                string query = @"
                    SELECT 
                        transaksi.id AS `ID Transaksi`,
                        transaksi.id_produk AS `ID Produk`,
                        products.nama_produk AS `Nama Barang`,
                        transaksi.id_user AS `ID User`,
                        transaksi.tanggal_transaksi AS `Tanggal Transaksi`
                    FROM 
                        transaksi
                    JOIN 
                        products ON transaksi.id_produk = products.id
                    WHERE ";

                if (kolom == "Nama Barang")
                    query += "products.nama_produk LIKE @keyword ";
                else if (kolom == "Tanggal Transaksi")
                    query += "transaksi.tanggal_transaksi LIKE @keyword ";
                else
                    query += "transaksi.id LIKE @keyword ";

                query += "ORDER BY transaksi.id DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable FilterTransaksiWithDate(string date)
        {
            string query = @"
                        SELECT 
                        transaksi.id AS `ID Transaksi`,
                        transaksi.id_produk AS `ID Produk`,
                        products.nama_produk AS `Nama Barang`,
                        transaksi.id_user AS `ID User`,
                        transaksi.tanggal_transaksi AS `Tanggal Transaksi`
                    FROM 
                        transaksi
                    JOIN 
                        products ON transaksi.id_produk = products.id
                    WHERE 
                        tanggal_transaksi = @tanggal
                    ORDER BY 
                        transaksi.id DESC";
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@tanggal",date);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }
            }

 
            
        }
        public static (int jumlah, int totalHarga, int harga) GetDetailTransaksi(int idTransaksi)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                conn.Open();
                string query = @"
                    SELECT dt.jumlah, dt.total_harga, p.harga 
                    FROM detail_transaksi dt
                    JOIN transaksi t ON dt.id_transaksi = t.id 
                    JOIN products p ON t.id_produk = p.id 
                    WHERE dt.id_transaksi = @idTransaksi";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);

                    using (var reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        return (
                            reader.GetInt32("jumlah"),
                            reader.GetInt32("total_harga"),
                            reader.GetInt32("harga")
                        );
                    }
                }
            }
        }

    }
}
