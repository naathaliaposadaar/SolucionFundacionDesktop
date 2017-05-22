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
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuAdminProductos menu = new MenuAdminProductos();
            menu.Show();
            Hide();
        }
    }
}
