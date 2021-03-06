﻿using AplicacionDesktop.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesktop.MENU
{
    public partial class MenuAdministrarInventario : Form
    {
        public MenuAdministrarInventario()
        {
            InitializeComponent();
        }

        private void btnIngresarI_Click(object sender, EventArgs e)
        {
            IngresarInventario inv = new IngresarInventario();
            inv.Show();
            Hide();

        }

        private void btnListarI_Click(object sender, EventArgs e)
        {
            ListarInventario inv = new ListarInventario();
            inv.Show();
            Hide();
        }

        private void btnModificarI_Click(object sender, EventArgs e)
        {
            ModificarInventario inv = new ModificarInventario();
            inv.Show();
            Hide();
        }

        private void btnEliminarI_Click(object sender, EventArgs e)
        {
            EliminarInventario inv = new EliminarInventario();
            inv.Show();
            Hide();
        }

        private void btnVolverI_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario menu = new MenuAdministrarInventario();
            menu.Show();
            Hide();
        }
    }
}
