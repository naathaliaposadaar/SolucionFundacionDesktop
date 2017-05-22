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

namespace AplicacionDesktop.CRUD
{
    public partial class ListarMedicamento : Form
    {
        public ListarMedicamento()
        {
            InitializeComponent();
            NegocioMedicina medicina = new NegocioMedicina();
            if (medicina.listarMedicinas().Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = medicina.listarMedicinas().Tables[0];
                dataGridView1.ReadOnly = true;
                dataGridView1.Update();
            }
            else
            {
                MessageBox.Show("No hay medicinas ingresadas");
            }
            
        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }
    }
}
