using AplicacionDesktop.MENU;
using Capa_DTO.Farmacia;
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
    public partial class IngresarInventario : Form
    {
        public IngresarInventario()
        {
            InitializeComponent();
        }
        
        //private void rdProducto_CheckedChanged(object sender, EventArgs e)
        //{
        //    NegocioProducto producto = new NegocioProducto();
        //    try
        //    {
        //        rdMedicina.Enabled = false;
        //        cbxMedicina.Enabled = false;
        //        if (producto.listarProductos().Tables[0].Rows.Count > 0)
        //        {

        //            cbxProducto.DataSource = producto.listarProductos().Tables[0];
        //            cbxProducto.DisplayMember = "nombre";
        //            cbxProducto.ValueMember = "id_producto";
        //            cbxProducto.SelectedIndex = -1;
        //            if (cbxProducto.SelectedIndex == -1)
        //            {
        //                cbxProducto.Text = "Seleccione un Producto";
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No hay productos ingresadas");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void rdMedicina_CheckedChanged(object sender, EventArgs e)
        //{
        //    rdProducto.Enabled = false;
        //    NegocioMedicina medic = new NegocioMedicina();
        //    try
        //    {
        //        if (medic.listarMedicinas().Tables[0].Rows.Count > 0)
        //        {
        //            cbxMedicina.DataSource = medic.listarMedicinas().Tables[0];
        //            //validar q contenga datos
        //            cbxMedicina.DisplayMember = "nom_comercial";
        //            cbxMedicina.ValueMember = "id_medicina";

        //            cbxMedicina.SelectedIndex = -1;
        //            if (cbxMedicina.SelectedIndex == -1)
        //            {
        //                cbxMedicina.Text = "Seleccione una Medicina";
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No hay medicinas ingresadas");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // seleccion = "";
            //INVENTARIO
            Inventario auxInventario = new Inventario();
            NegocioInventario inventario = new NegocioInventario();
            //BODEGA MEDICA
            BodegaMedica auxBmedicina = new BodegaMedica();
            NegocioBodegaM bMedicina = new NegocioBodegaM();
            //MEDICINA
            NegocioMedicina medicina = new NegocioMedicina();
            Medicina auxMedicina = new Medicina();
            //BODEGA PRODUCTO
            NegocioBodegaP bProducto = new NegocioBodegaP();
            BodegaProducto auxBproducto = new BodegaProducto();
            //PRODUCTO
            NegocioProducto producto = new NegocioProducto();
            Producto auxProducto = new Producto();
            
            try
            {
                if (txtCantidad.Text != "" || txtObservaciones.Text !="")
                {
                    if (DateTime.Compare(dtpFecha.Value.Date, DateTime.Today) >= 0)
                    {
                        if (validaCampoVacio(txtObservaciones) && validaCampoVacio(txtCantidad))
                        {
                            if (rdMedicina.Checked || rdProducto.Checked)
                            {


                                //Inventario
                                auxInventario.Cantidad_productos = int.Parse(txtCantidad.Text);
                                auxInventario.Observaciones = txtObservaciones.Text;
                                auxInventario.Fecha_inventario = dtpFecha.Value;
                                if (rdMedicina.Checked && cbxMedicina.SelectedIndex != 1)
                                {
                                    rdProducto.Enabled = false;
                                    NegocioMedicina medic = new NegocioMedicina();
                                    try
                                    {
                                        if (medic.listarMedicinas().Tables[0].Rows.Count > 0)
                                        {
                                            cbxMedicina.DataSource = medic.listarMedicinas().Tables[0];
                                            //validar q contenga datos
                                            cbxMedicina.DisplayMember = "nom_comercial";
                                            cbxMedicina.ValueMember = "id_medicina";

                                            cbxMedicina.SelectedIndex = -1;
                                            if (cbxMedicina.SelectedIndex == -1)
                                            {
                                                cbxMedicina.Text = "Seleccione una Medicina";
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
                                    
                                    if (inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario, auxInventario.Cantidad_productos) == 0)
                                    {

                                        DialogResult dialogResult = MessageBox.Show("Desea agregarinventario de la medicina: " + cbxMedicina.Text, "Información", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            DialogResult result = MessageBox.Show("Se ingresara el inventario de la medicina ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                            switch (result)
                                            {


                                                case DialogResult.Yes:
                                                    if (inventario.ingresarInventario(auxInventario) > 0)
                                                    {
                                                        //Bodega Medicina
                                                        auxBmedicina.Id_medicina = int.Parse(cbxMedicina.SelectedValue.ToString());
                                                        //obtener id inventario
                                                        auxInventario.Id_inventario = inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario, auxInventario.Cantidad_productos);
                                                        
                                                        //obtener medicina
                                                        auxMedicina = medicina.consultarPorIdMedicina(auxBmedicina.Id_medicina);
                                                        //obtener cantidad medicina
                                                        auxBmedicina.Stock = auxMedicina.Cantidad;

                                                        if (bMedicina.ingresarBodegaMedica(auxBmedicina, auxInventario.Id_inventario) > 0)
                                                        {

                                                            txtCantidad.Text = "";
                                                            txtObservaciones.Text = "";
                                                            dtpFecha.Value = DateTime.Now;
                                                            cbxMedicina.SelectedIndex = -1;
                                                            rdMedicina.Checked = false;

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("ERROR");
                                                        }
                                                    }
                                                    break;
                                                case DialogResult.No:
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("ERROR");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ERROR");
                                }
                                if (rdProducto.Checked && cbxProducto.SelectedIndex != 1)
                                {
                                    NegocioProducto produc = new NegocioProducto();
                                    try
                                    {
                                        rdMedicina.Enabled = false;
                                        cbxMedicina.Enabled = false;
                                        if (producto.listarProductos().Tables[0].Rows.Count > 0)
                                        {

                                            cbxProducto.DataSource = produc.listarProductos().Tables[0];
                                            cbxProducto.DisplayMember = "nombre";
                                            cbxProducto.ValueMember = "id_producto";
                                            cbxProducto.SelectedIndex = -1;
                                            if (cbxProducto.SelectedIndex == -1)
                                            {
                                                cbxProducto.Text = "Seleccione un Producto";
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("No hay productos ingresadas");
                                        }
                                    }
                                    catch (Exception)
                                    {

                                        throw;
                                    }
                                    
                                    if (inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario, auxInventario.Cantidad_productos) == 0)
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Desea agregarinventario de la medicina: " + cbxProducto.Text, "Información", MessageBoxButtons.YesNo);
                                        if (dialogResult == DialogResult.Yes)
                                        {
                                            DialogResult result = MessageBox.Show("Se ingresara el inventario de la medicina ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                            switch (result)
                                            {


                                                case DialogResult.Yes:
                                                    if (inventario.ingresarInventario(auxInventario) > 0)
                                                    {
                                                        //obtener id inventario
                                                        auxInventario.Id_inventario = inventario.consultarInventario(auxInventario.Observaciones, auxInventario.Fecha_inventario, auxInventario.Cantidad_productos);
                                                        //obtener id Inventario
                                                        auxBproducto.Id_producto = int.Parse(cbxProducto.SelectedValue.ToString());
                                                        //Obtener cantidad producto
                                                        //?? como obtener cantidad
                                                        auxBproducto.Stock = int.Parse(txtCantidad.Text);
                                    
                                                        if (bProducto.ingresarBodegaProducto(auxBproducto, auxInventario.Id_inventario) > 0)
                                                        {

                                                            txtCantidad.Text = "";
                                                            txtObservaciones.Text = "";
                                                            dtpFecha.Value = DateTime.Now;
                                                            cbxMedicina.SelectedIndex = -1;
                                                            rdMedicina.Checked = false;

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("ERROR AL INGRESAR BODEGA PRODUCTO");
                                                        }
                                                    }
                                                    break;
                                                case DialogResult.No:
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Este inventario ya esta registrado");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Seleccione una medicina");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione producto o medicina");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese todos los campos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha  no puede ser mayor o igual a la fecha de hoy");
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo vacío");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario adInv = new MenuAdministrarInventario();
            adInv.Show();
            Hide();
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

    }
}
