﻿using AplicacionDesktop.MENU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.CRUD
{
    public partial class IngresarCompra : Form
    {
        public IngresarCompra()
        {
            InitializeComponent();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra();
            mCompra.Show();
            Hide();
        }
    }
}
