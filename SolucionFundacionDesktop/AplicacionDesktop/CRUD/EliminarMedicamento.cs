using AplicacionDesktop.MENU;
using Capa_DTO.Medicamento;
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
    public partial class EliminarMedicamento : Form
    {
        public EliminarMedicamento()
        {
            InitializeComponent();
            cargarCombobox();
           
            
            
        }
        public void cargarCombobox()
        {
            NegocioMedicina medic = new NegocioMedicina();
            try
            {
                if (medic.listarMedicinas().Tables[0].Rows.Count>0)
                {
                    cbxMed.DataSource = medic.listarMedicinas().Tables[0];
                    //validar q contenga datos
                    cbxMed.DisplayMember = "nom_comercial";
                    cbxMed.ValueMember = "id_medicina";

                    cbxMed.SelectedIndex = -1;
                    if (cbxMed.SelectedIndex == -1)
                    {
                        cbxMed.Text = "Seleccione una Medicina";
                    }
                }
                else
                {
                    MessageBox.Show("No hay medicinas ingresadas");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            Medicina auxMed = new Medicina();
            NegocioMedicina auxNegMed = new NegocioMedicina();
            try
            {
                if (auxNegMed.listarMedicinas().Tables[0].Rows.Count>0)
                {
                    auxMed.Id_medicina = int.Parse(cbxMed.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Está intentando eliminar un Medicamento. Si continua el proceso, se eliminaran TODOS los datos asociados a este. Desea continuar?", "Atención!. Lea cuidadosamente.", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (auxNegMed.eliminarMedicamento(auxMed.Id_medicina) > 0)
                            {                                                             
                                MessageBox.Show("Medicina eliminada.", "Información");
                                cargarCombobox();                                
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar medicamento");
                            }

                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("No hay medicinas ingresadas");
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
