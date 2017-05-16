using AplicacionDesktop.MENU;
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

        }

        private void btnModificarI_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarI_Click(object sender, EventArgs e)
        {

        }
    }
}
