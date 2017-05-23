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

namespace AplicacionDesktop.CRUD
{
    public partial class ModificarMedicamento : Form
    {
        public ModificarMedicamento()
        {
            InitializeComponent();
            // obj
            NegocioMedicina medicina = new NegocioMedicina();
            //Llenar cbx
            cbxNombre_C.DataSource = medicina.listarMedicinas().Tables[0];
            cbxNombre_C.DisplayMember = "nom_comercial";
            cbxNombre_C.ValueMember = "id_medicina";
            
        }

        private void focusComponente(TextBox text)
        {
            text.Focus();
        }

        private Boolean validaCampoVacio(TextBox campo)
        {
            if (String.IsNullOrEmpty(campo.Text.Trim()))
            {
                return true;
            }
            else
            {
               
                focusComponente(campo);
                return false;
            }
        }
        private void btnModificarM_Click(object sender, EventArgs e)
        {
            try
            {
                
                Medicina auxMedicina = new Medicina();
                NegocioMedicina medicina = new NegocioMedicina();
                DialogResult dialogResult = MessageBox.Show("Desea modificar la Medicina: " + cbxNombre_C.Text.ToString(), "Información", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult result = MessageBox.Show("Se modificara la medicina ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (txtNombreG.Text != ""  | txtContenido.Text != "" | txtContenido.Text != "" | cbxum.SelectedIndex != -1 | txtCantidad.Text != "" | txtDes.Text != "")
                {
                    // La fecha de fabricacion y vencimientos sean diferentes
                    if (dtpff.Text.CompareTo(dtpfv.Text) != 0)
                    {
                        //Que la fecha de fabricacion sea menor o igual a la fecha de hoy
                        if (DateTime.Compare(dtpff.Value.Date, DateTime.Today) == 0 || DateTime.Compare(dtpff.Value.Date, DateTime.Today)<0)
                        {
                            //La fecha de vencimiento  sea mayor  a la fecha de hoy 
                            if (DateTime.Compare(dtpfv.Value.Date, DateTime.Today) != 0 || DateTime.Compare(dtpfv.Value.Date, DateTime.Today)>0)
                            {

                                auxMedicina.Nom_generico = txtNombreG.Text.ToUpper().Trim();
                                auxMedicina.Contenido = txtContenido.Text.ToUpper().Trim(); ;
                                auxMedicina.Unidad_medida = cbxum.SelectedValue.ToString().ToUpper().Trim(); ;                                
                                auxMedicina.Cantidad = int.Parse(txtCantidad.Text);
                                auxMedicina.Fec_fabricacion = dtpff.Value;
                                auxMedicina.Fec_vencimiento = dtpfv.Value;
                                auxMedicina.Id_medicina = int.Parse(cbxNombre_C.SelectedValue.ToString());
                                auxMedicina.Descripcion = txtDes.Text.ToUpper();
                                if (medicina.actualizarMedicina(auxMedicina)>0)
                                {

                                    MessageBox.Show("Medicina Modificada", "Información");
                                    //limpiar campos
                                    cbxum.SelectedIndex = -1;
                                    txtNombreG.Text = "";                                    
                                    txtContenido.Text = "";
                                    txtCantidad.Text = "";
                                    txtDes.Text = "";
                                    dtpff.Value = DateTime.Now;
                                    dtpfv.Value = DateTime.Now;
                                    cbxNombre_C.DataSource = medicina.listarMedicinas().Tables[0];
                                    dataGridView1.DataSource = medicina.medicinaModificada(auxMedicina.Id_medicina).Tables[0];
                                    dataGridView1.ReadOnly = true;
                                    dataGridView1.Update();
                                }
                                else
                                {
                                    MessageBox.Show("ERROR");
                                }
                            }                           
                            
                        else
                            {
                                MessageBox.Show("La fecha de vencimiento no puede ser menor o igual a la fecha de hoy");
                            }
                        }

                        else
                        {
                            MessageBox.Show("La fecha de fabricacion no puede ser mayor a la fecha de hoy");
                        }
                    }
                    else
                    {
                        //La fecha de fabricacion no puede ser igual a la fecha de vencimiento
                        MessageBox.Show("La fecha de fabricacion no puede ser igual a la fecha de vencimiento");
                    }
                    }

                            break;
                        case DialogResult.No:
                            break;
}
                            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR. " + ex);
            }
        }
        
        private void btnVolverr_Click(object sender, EventArgs e)
        {
            MenuAdminMedicamentos med = new MenuAdminMedicamentos();
            med.Show();
            Hide();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbxNombre_C_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //Unidad medida
            Dictionary<string, string> undMed = new Dictionary<string, string>();
            undMed.Add("G", "GRAMOS");
            undMed.Add("MG", "MILIGRAMOS");
            undMed.Add("ML", "MILILITROS");
            undMed.Add("L", "LITROS");
            cbxum.DisplayMember = "Value";
            cbxum.ValueMember = "Key";
            // obj NegMed
            NegocioMedicina medicina = new NegocioMedicina();
            //Llenar cbx
            //cbxNombre_C.DataSource = medicina.listarMedicinas().Tables[0];
            // Obj Med
            Medicina auxMed = new Medicina();
            //Recuperar Medicina
            auxMed = medicina.consultarPorIdMedicina(int.Parse(cbxNombre_C.SelectedValue.ToString()));
            //llenar camposcbxum.SelectedIndex = -1;
            txtNombreG.Text = auxMed.Nom_generico;
            txtContenido.Text = auxMed.Contenido;
            txtCantidad.Text = auxMed.Cantidad.ToString();
            txtDes.Text = auxMed.Descripcion;
            dtpff.Text = auxMed.Fec_fabricacion.ToString();
            dtpfv.Text = auxMed.Fec_vencimiento.ToString();
            cbxum.Text = auxMed.Unidad_medida;            
            cbxum.DataSource = undMed.ToArray();

            if (auxMed.Unidad_medida.ToUpper().ToString().Equals("G"))
            {
                cbxum.Text = "GRAMOS";
            }
            else if (auxMed.Unidad_medida.ToUpper().ToString().Equals("MG"))
            {
                cbxum.Text = "MILIGRAMOS";
            }
            else if (auxMed.Unidad_medida.ToUpper().ToString().Equals("L"))
            {
                cbxum.Text = "LITROS";
            }
            else
            {
                cbxum.Text = "MILILITROS";
            }

            
        }
    }
}
