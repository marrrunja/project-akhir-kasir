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
                    object ores = MySqlHelper.ExecuteScalar(conn, "SELECT LAST_INSERT_ID();");

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
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal insert data " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

            }
        }

        public static DataTable getAllData()
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM products";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
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


        public static int hapusData(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM products WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int afffectedRows = cmd.ExecuteNonQuery();

                    return afffectedRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus data " + ex.Message);
                    return 0;
                }
            }
        }

        public static int updateData(int id, string nama, int harga, int stok)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE products SET nama_produk = @nama, harga = @harga, stok = @stok WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    int afffectedRows = cmd.ExecuteNonQuery();

                    return afffectedRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update data " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }
        public static DataTable searchData(string kolom, string keyword)
        {
            string query = $"SELECT * FROM products WHERE {kolom} LIKE @keyword ORDER BY ID DESC";
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
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
        public static DataTable tampilkanDataDefault(ref int totalRecords, ref int totalPage, ref int currentPage, ref int pageSize)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                try
                {
                    conn.Open();
                    string countQuery = "SELECT COUNT(*) FROM products";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);

                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    totalPage = (int)Math.Ceiling((double)totalRecords / pageSize);

                    if (currentPage > totalPage) currentPage = totalPage;
                    if (currentPage < 1) currentPage = 1;

                    int offset = (currentPage - 1) * pageSize;

                    string query = "SELECT id, id_produk, harga, stok, nama_produk FROM products ORDER BY id ASC LIMIT @limit OFFSET @offset";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@limit", pageSize);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }
            }
        }
    }
}