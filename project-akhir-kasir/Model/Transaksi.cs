using MySql.Data.MySqlClient;
using project_akhir_kasir.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_kasir.Model
{
    class Transaksi
    {
        public static int InsertTransaksi(string idProduk, int idUser, int jumlah, int total)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                conn.Open();

                // Insert ke transaksi
                string insertTransaksi = "INSERT INTO transaksi (id_produk, id_user, tanggal_transaksi) VALUES (@id_produk, @id_user, NOW()); SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(insertTransaksi, conn);
                cmd.Parameters.AddWithValue("@id_produk", idProduk);
                cmd.Parameters.AddWithValue("@id_user", idUser);

                long idTransaksi = Convert.ToInt64(cmd.ExecuteScalar());

                // Insert ke detail_transaksi
                string insertDetail = "INSERT INTO detail_transaksi (jumlah, total_harga, id_transaksi) VALUES (@jumlah, @total, @id_transaksi)";
                MySqlCommand cmdDetail = new MySqlCommand(insertDetail, conn);
                cmdDetail.Parameters.AddWithValue("@jumlah", jumlah);
                cmdDetail.Parameters.AddWithValue("@total", total);
                cmdDetail.Parameters.AddWithValue("@id_transaksi", idTransaksi);

                return cmdDetail.ExecuteNonQuery();
            }
        }

    }
}
