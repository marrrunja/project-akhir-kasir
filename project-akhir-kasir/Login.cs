using CrystalDecisions.Windows.Forms;
using MySql.Data.MySqlClient;
using project_akhir_kasir.Config;
namespace project_akhir_kasir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textboxUsername.Text = "muammar";
            textboxPassword.Text = "123";
        }

        private bool HandeLogin(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password from users WHERE username = @username";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        String hash = reader.GetString("password");
                        Boolean isTrue = BCrypt.Net.BCrypt.Verify(password, hash);
                        return isTrue;
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal terhubung ke database " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;



            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau password tidak boleh kosong ", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (HandeLogin(username, password))
            {
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textboxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
