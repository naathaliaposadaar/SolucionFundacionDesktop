using AplicacionDesktop.MENU;
using CapaNegocio.NegocioFarmacia;
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
    public partial class ListarMedicamento : Form
    {
        public ListarMedicamento()
        {
            InitializeComponent();
            NegocioMedicina medicina = new NegocioMedicina();
            dataGridView1.DataSource = medicina.listarMedicinas().Tables[0];
            dataGridView1.ReadOnly = true;
            dataGridView1.Update();
        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }
    }
}
