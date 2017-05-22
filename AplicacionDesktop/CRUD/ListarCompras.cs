using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.MENU;
using CapaNegocio.NegocioFarmacia;

namespace AplicacionDesktop.CRUD
{
    public partial class ListarCompras : Form
    {
        public ListarCompras()
        {
            InitializeComponent();
            NegocioCompra compra = new NegocioCompra();
            if (compra.listarCompras().Tables[0].Rows.Count > 0)
            {

                dataGridView1.DataSource = compra.listarCompras().Tables[0];
                dataGridView1.ReadOnly = true;
                dataGridView1.Update();

                //dataGridView1.ColumnHeadersVisible = false;
            }
            else
            {
                MessageBox.Show("No hay datos ingresads");
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            MenuAdminCompra mCompra = new MenuAdminCompra();
            mCompra.Show();
            Hide();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {

        }
    }
}
