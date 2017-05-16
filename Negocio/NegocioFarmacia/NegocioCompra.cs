using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioCompra
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_compra = "seq_compra.nextval";

        public string Seq_compra
        {
            get
            {
                return _seq_compra;
            }

            set
            {
                _seq_compra = value;
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
            Conectar.NombreTabla = "COMPRA";
            Conectar.CadenaConexion = "DATA SOURCE=nathalia-PC;USER ID=FUNDACION ; password =123";

        }

        public int ingresarCompra(Compra compra)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_compra, descripcion, montototal, fecha,id_det_compra) VALUES({1},'{2}',{3},TO_DATE('{4}','dd/mm/yyyy hh24:mi:ss'),{5})",
                                                   conectar.NombreTabla, Seq_compra, compra.Descripcion,compra.MontoTotal,compra.Fecha,compra.Id_det_compra);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarCompra(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_compra = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarCompra(Compra com)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE COMPRA SET montototal={0},"
                                                        + " descripcion ='{1}',"
                                                        + " fecha='{2}',"                                                        
                                                        + " id_det_compra={3}"
                                                        + " WHERE id_compra ={4}"
                                                        , com.MontoTotal,com.Descripcion,com.Fecha,com.Id_det_compra,com.Id_compra);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarCompra(int id)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT fecha FROM {0} WHERE id_det_compra = {1}",
                                     conectar.NombreTabla, id);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarCompras()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM compra order by id_compra";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet compraModificada(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_compra = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public Compra consultarPorId(int id)
        {

            configuraConexion();

            Compra auxCompra = new Compra();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_compra = {1} order by id_compra",
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
                        auxCompra.Id_compra = int.Parse(dt.Rows[0]["id_compra"].ToString());
                        auxCompra.Descripcion = dt.Rows[0]["descripcion"].ToString();
                        auxCompra.MontoTotal = int.Parse(dt.Rows[0]["montototal"].ToString());
                        auxCompra.Fecha = DateTime.Parse(dt.Rows[0]["tipo"].ToString());
                        auxCompra.Id_det_compra = int.Parse(dt.Rows[0]["id_det_compra"].ToString());
                        

                    }
                    catch (Exception)
                    {
                        auxCompra.Id_compra = 0;
                        auxCompra.Descripcion = "";
                        auxCompra.MontoTotal = 0;
                        auxCompra.Fecha = DateTime.Now;
                        auxCompra.Id_det_compra = 0;
                    }
                }
            }
            else
            {
                auxCompra = null;
            }
            return auxCompra;
        }
    }
}
