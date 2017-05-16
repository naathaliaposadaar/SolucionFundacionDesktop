using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioProducto
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_producto = "seq_producto.nextval";

        public string Seq_producto
        {
            get
            {
                return _seq_producto;
            }

            set
            {
                _seq_producto = value;
            }
        }

        public Conexion Conectar
        {
            get
            {
                return conectar;
            }

            set
            {
                conectar = value;
            }
        }

        public void configuraConexion()
        {
            Conectar = new Conexion();
            Conectar.NombreBaseDeDatos = "FUNDACION";
            Conectar.NombreTabla = "PRODUCTO";
            Conectar.CadenaConexion = "DATA SOURCE=nathalia-PC;USER ID=FUNDACION ; password =123";

        }

        public int ingresarProducto(Producto producto)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_producto, nombre, categoria, tipo,precio,id_proveedor) VALUES({1},'{2}','{3}','{4}',{5},{6})",
                                                   conectar.NombreTabla,Seq_producto,producto.Nombre,producto.Categoria,producto.Tipo,producto.Precio,producto.Id_proveedor);
           

            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarProducto(int producto)
        {
            
            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_producto = {1}",
                                                  this.conectar.NombreTabla, producto);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarProducto(Producto prod)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE producto SET precio={0},"
                                                        + " nombre ='{1}',"
                                                        + " categoria='{2}',"
                                                        + " tipo='{3}',"
                                                        + " id_proveedor={4}"
                                                        + " WHERE id_producto ={5}"
                                                        , prod.Precio,prod.Nombre,prod.Categoria,prod.Tipo,prod.Id_proveedor,prod.Id_producto);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarProducto(String producto)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT nombre FROM {0} WHERE nombre = '{1}'",
                                     conectar.NombreTabla, producto);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarProductos()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM PRODUCTO order by ID_PRODUCTO";           
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        
        public System.Data.DataSet productoModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_PRODUCTO = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public Producto consultarPorId(int id)
        {

            configuraConexion();

            Producto auxProducto = new Producto();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_PRODUCTO = {1} order by ID_PRODUCTO",
                                      conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            if (conectar.conecta() != 0)
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                if (conectar.DbDataSet.Tables[0].Rows.Count >= 1)
                {
                    dt = conectar.DbDataSet.Tables[0];

                    try
                    {
                        auxProducto.Id_producto = int.Parse(dt.Rows[0]["id_producto"].ToString());
                        auxProducto.Nombre = dt.Rows[0]["nombre"].ToString();
                        auxProducto.Categoria = dt.Rows[0]["categoria"].ToString();
                        auxProducto.Tipo = dt.Rows[0]["tipo"].ToString();
                        auxProducto.Precio = int.Parse(dt.Rows[0]["precio"].ToString());
                        auxProducto.Id_proveedor = int.Parse(dt.Rows[0]["id_proveedor"].ToString());                       

                    }
                    catch (Exception)
                    {
                        auxProducto.Id_producto =0;
                        auxProducto.Nombre = "";
                        auxProducto.Categoria ="";
                        auxProducto.Tipo = "";
                        auxProducto.Precio = 0;
                        auxProducto.Id_proveedor = 0;
                    }
                }
            }
            else
            {
                auxProducto = null;
            }
            return auxProducto;
        }
    }
}
