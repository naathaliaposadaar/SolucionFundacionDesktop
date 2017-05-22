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

namespace AplicacionDesktop.CRUD
{
    public partial class ModificarInventario : Form
    {
        public ModificarInventario()
        {
            InitializeComponent();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario inv = new MenuAdministrarInventario();
            inv.Show();
            Hide();
        }
    }
}
