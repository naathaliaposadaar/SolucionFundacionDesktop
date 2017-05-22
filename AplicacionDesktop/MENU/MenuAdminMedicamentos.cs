using AplicacionDesktop.CRUD;
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
    public partial class MenuAdminMedicamentos : Form
    {
        public MenuAdminMedicamentos()
        {
            InitializeComponent();
        }

        private void MenuAdminMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarU_Click(object sender, EventArgs e)
        {
            IngresarMedicamentos ingresar = new IngresarMedicamentos();
            ingresar.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarMedicamento listar = new ListarMedicamento();
            listar.Show();
            Hide();

        }

        private void btnModificarU_Click(object sender, EventArgs e)
        {
            ModificarMedicamento modificar = new ModificarMedicamento();
            modificar.Show();
            Hide();
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            EliminarMedicamento eliminar = new EliminarMedicamento();
            eliminar.Show();
            Hide();
        }

        private void btnVolverU_Click(object sender, EventArgs e)
        {
            MenuSupervisor mSupervisor = new MenuSupervisor();
            mSupervisor.Show();
        }
    }
}
