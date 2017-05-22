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
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
        }

        private void btnAdMedicina_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos menuMed = new MenuAdminMedicamentos();
            menuMed.Show();
            Hide();
        }

        private void btnAdProducto_Click(object sender, EventArgs e)
        {
            MenuAdminProductos menuProd = new MenuAdminProductos();
            menuProd.Show();
            Hide();
        }

        private void btnAdInventario_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario menuInv = new MenuAdministrarInventario();
            menuInv.Show();
            Hide();
        }

        private void btnAdProveedor_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor menuProv = new MenuAdminProveedor();
            menuProv.Show();
            Hide();
        }

        private void btnAdCompra_Click(object sender, EventArgs e)
        {
            MenuAdminCompra menuCompra = new MenuAdminCompra();
            menuCompra.Show();
            Hide();
        }

        private void btnAdSolicitudMed_Click(object sender, EventArgs e)
        {
            MenuAdminSolicitudMedica menuSMed = new MenuAdminSolicitudMedica();
            menuSMed.Show();
            Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Seguro que desea cerrar?", "Cerrar", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:

                    this.Close();
                    Application.Exit();

                    break;
                case DialogResult.No:
                    break;

            }
        }
    }
}
