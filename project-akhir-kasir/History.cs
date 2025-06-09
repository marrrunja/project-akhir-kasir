using project_akhir_kasir.Config;
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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();

        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Helper.redirectTo(this, mainMenu);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
