﻿using project_akhir_kasir.Config;
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

        private void ManageBarangBtn_Click(object sender, EventArgs e)
        {
            Helper.redirectTo(this, new ManageBarang());
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void HistoryBtn_Click_1(object sender, EventArgs e)
        {
            Helper.redirectTo(this, new History());
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
