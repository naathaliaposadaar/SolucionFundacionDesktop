using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDetalleCompra
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_det_compra = "seq_det_compra.nextval";

        public string Seq_det_compra
        {
            get
            {
                return _seq_det_compra;
            }

            set
            {
                _seq_det_compra = value;
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
            Conectar.NombreTabla = "DET_COMPRA";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarDetalleCompra(DetalleCompra dtCompra)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_det_compra, cantidad, total, descripcion,id_producto) VALUES({1},{2},{3},'{4}',{5})",
                                                   conectar.NombreTabla, Seq_det_compra,dtCompra.Cantidad,dtCompra.Total,dtCompra.Descripcion,dtCompra.Id_producto);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarDetalleCompra(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_det_compra = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarMedicina(DetalleCompra dtCompra )
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE DET_COMPRA SET cantidad={0},"
                                                        + " total ={1},"
                                                        + " descripcion='{2}',"                                                        
                                                        + " id_producto={3}"
                                                        + " WHERE id_producto ={4}"
                                                        ,dtCompra.Cantidad,dtCompra.Total,dtCompra.Descripcion,dtCompra.Id_producto,dtCompra.Id_det_compra );
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarDetalleCompra(int detalle)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT id_det_compra FROM {0} WHERE id_det_compra = {1}",
                                     conectar.NombreTabla, detalle);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarDetalleCompras()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM DET_COMPRA order by ID_DET_COMPRA";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet detalleModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_DET_COMPRA = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public DetalleCompra consultarPorId(int id)
        {

            configuraConexion();

            DetalleCompra auxDetCompra = new DetalleCompra();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_DET_COMPRA = {1} order by ID_DET_COMPRA",
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
                        auxDetCompra.Id_det_compra = int.Parse(dt.Rows[0]["ID_DET_COMPRA"].ToString());
                        auxDetCompra.Cantidad = int.Parse(dt.Rows[0]["cantidad"].ToString());
                        auxDetCompra.Total = int.Parse(dt.Rows[0]["total"].ToString());
                        auxDetCompra.Descripcion = dt.Rows[0]["descripcion"].ToString();
                        auxDetCompra.Id_producto = int.Parse(dt.Rows[0]["id_producto"].ToString());
                        

                    }
                    catch (Exception)
                    {
                        auxDetCompra.Id_det_compra = 0;
                        auxDetCompra.Cantidad = 0;
                        auxDetCompra.Total = 0;
                        auxDetCompra.Descripcion = "";
                        auxDetCompra.Id_producto = 0;
                    }
                }
            }
            else
            {
                auxDetCompra = null;
            }
            return auxDetCompra;
        }
    }
}
