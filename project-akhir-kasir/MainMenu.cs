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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void KasirBtn_Click(object sender, EventArgs e)
        {
            FormKasir kasir = new FormKasir();
            Helper.redirectTo(this, kasir);
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageBarangBtn_Click(object sender, EventArgs e)
        {
            ManageBarang manageBarang = new ManageBarang();
            Helper.redirectTo(this, manageBarang);
        }
    }
}
