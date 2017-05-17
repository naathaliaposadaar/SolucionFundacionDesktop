using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioBodegaP
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_bod_prod = "seq_bod_prod.nextval";

        public string Seq_bod_prod
        {
            get
            {
                return _seq_bod_prod;
            }

            set
            {
                _seq_bod_prod = value;
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
            Conectar.NombreTabla = "BODEGA_PROD";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarBodegaProducto(BodegaProducto bodProd, int inventario)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_bodega_prod, stock, id_producto, id_inventario) VALUES({1},{2},{3},{4})",
                                                   conectar.NombreTabla,Seq_bod_prod,bodProd.Stock,bodProd.Id_producto,inventario);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarBodegaProducto(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_bodega_prod = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarBodegaProducto(BodegaProducto bodProd)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE bodega_prod SET stock={0},"
                                                        + " id_producto ={1},"
                                                        + " id_inventario={2}"
                                                        + " WHERE id_bodega_prod ={3}"
                                                        , bodProd.Stock,bodProd.Id_producto,bodProd.Id_inventario,bodProd.Id_bodega_prod);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarBodegaProducto(int producto)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT stock FROM {0} WHERE id_producto = {1}",
                                     conectar.NombreTabla, producto);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarBodegaProducto()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM bodega_prod order by id_bodega_prod";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet productoModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_bodega_prod = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public BodegaProducto consultarPorId(int id)
        {

            configuraConexion();

            BodegaProducto auxBodProducto = new BodegaProducto();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_bodega_prod = {1} order by id_bodega_prod",
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
                        auxBodProducto.Id_producto = int.Parse(dt.Rows[0]["id_bodega_prod"].ToString());
                        auxBodProducto.Id_producto = int.Parse(dt.Rows[0]["id_producto"].ToString());
                        auxBodProducto.Id_inventario = int.Parse(dt.Rows[0]["id_inventario"].ToString());
                        auxBodProducto.Stock = int.Parse(dt.Rows[0]["stock"].ToString());
                        
                    }
                    catch (Exception)
                    {
                        auxBodProducto.Id_producto = 0;
                        auxBodProducto.Id_producto = 0;
                        auxBodProducto.Id_inventario = 0;
                        auxBodProducto.Stock = 0;
                        
                    }
                }
            }
            else
            {
                auxBodProducto = null;
            }
            return auxBodProducto;
        }
    }
}
