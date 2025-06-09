using MySql.Data.MySqlClient;
using project_akhir_kasir.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_akhir_kasir.Model
{
    class Produk
    {
   
        public static int insertData(string nama, int harga, int stok)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                try
                {
                    conn.Open();
                    int id = 0;

                    String query = "INSERT INTO products (nama_produk, harga, stok) VALUES(@nama, @harga, @stok)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);

                    String kodeBarang = "BRG-";

                    int affectedRows = cmd.ExecuteNonQuery();
                    object ores = MySqlHelper.ExecuteScalar(conn,"SELECT LAST_INSERT_ID();");

                    if (ores != null)
                    {
                        // Odd, I got ulong here.
                        ulong qkwl = (ulong)ores;
                        id = (int)qkwl;
                        kodeBarang += id;
                    }
                   
                    String queryUpdate = "UPDATE products SET id_produk = @kode WHERE id = @id";
                     MySqlCommand cmd2 = new MySqlCommand(queryUpdate, conn);
                    cmd2.Parameters.AddWithValue("@kode", kodeBarang);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();

                    return affectedRows;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal insert data " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

            }
        }

        
    }
}
