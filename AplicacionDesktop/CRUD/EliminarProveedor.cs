using AplicacionDesktop.MENU;
using Capa_DTO.Farmacia;
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
    public partial class EliminarProveedor : Form
    {
        public EliminarProveedor()
        {
            InitializeComponent();
        }
        public void cargarCombobox()
        {
            NegocioProveedor prov = new NegocioProveedor();
            try
            {
                if (prov.listarProveedor().Tables[0].Rows.Count > 0)
                {
                    cbxProducto.DataSource = prov.listarProveedor().Tables[0];
                    //validar q contenga datos
                    cbxProducto.DisplayMember = "razon_social";
                    cbxProducto.ValueMember = "id_proveedor";

                    cbxProducto.SelectedIndex = -1;
                    if (cbxProducto.SelectedIndex == -1)
                    {
                        cbxProducto.Text = "Seleccione un Proveedor";
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos ingresadas");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor men = new MenuAdminProveedor();
            men.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdminProveedor men = new MenuAdminProveedor();
            men.Show();
            Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Proveedor auxProv = new Proveedor();
            NegocioProveedor auxNProv = new NegocioProveedor();
            try
            {
                if (auxNProv.listarProveedor().Tables[0].Rows.Count > 0)
                {
                    auxProv.Id_proveedor = int.Parse(cbxProducto.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Está intentando eliminar. Si continua el proceso, se eliminaran TODOS los datos asociados a este. Desea continuar?", "Atención!. Lea cuidadosamente.", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (auxNProv.eliminarProveedor(auxProv.Id_proveedor) > 0)
                            {
                                MessageBox.Show("Eliminado.", "Información");
                                cargarCombobox();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar");
                            }

                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos ingresados");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
