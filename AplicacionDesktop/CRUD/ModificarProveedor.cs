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
    public partial class ModificarProveedor : Form
    {
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor menu = new MenuAdminProveedor();
            menu.Show();
            Hide();
        }
    }
}
