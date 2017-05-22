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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }
        public void cargarCombobox()
        {
            NegocioProducto produc = new NegocioProducto();
            try
            {
                if (produc.listarProductos().Tables[0].Rows.Count > 0)
                {
                    cbxProd.DataSource = produc.listarProductos().Tables[0];
                    //validar q contenga datos
                    cbxProd.DisplayMember = "nombre";
                    cbxProd.ValueMember = "id_producto";

                    cbxProd.SelectedIndex = -1;
                    if (cbxProd.SelectedIndex == -1)
                    {
                        cbxProd.Text = "Seleccione un Producto";
                    }
                }
                else
                {
                    MessageBox.Show("No hay Productos ingresadas");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            Producto auxProd = new Producto();
            NegocioProducto AuxNproduc = new NegocioProducto();
            try
            {
                if (AuxNproduc.listarProductos().Tables[0].Rows.Count > 0)
                {
                    auxProd.Id_producto = int.Parse(cbxProd.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Está intentando eliminar un Medicamento. Si continua el proceso, se eliminaran TODOS los datos asociados a este. Desea continuar?", "Atención!. Lea cuidadosamente.", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (AuxNproduc.eliminarProducto(auxProd.Id_producto) > 0)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }
    }
}
