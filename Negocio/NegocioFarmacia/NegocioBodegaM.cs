using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioBodegaM
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_bod_med = "seq_bod_med.nextval";

        public string Seq_bod_med
        {
            get
            {
                return _seq_bod_med;
            }

            set
            {
                _seq_bod_med = value;
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
            Conectar.NombreTabla = "BODEGA_MED";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarBodegaMedica(BodegaMedica bodMed, int inventario)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_bodega_med, stock, id_medicina, id_inventario) VALUES({1},{2},{3},{4})",
                                                   conectar.NombreTabla, Seq_bod_med,bodMed.Stock,bodMed.Id_medicina,inventario);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarBodegaMedica(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_bodega_med = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarBodegaMedica(BodegaMedica bM)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE bodega_med SET stock={0},"
                                                        + " id_medicina ={1},"
                                                        + " id_inventario={2}"
                                                        + " WHERE id_bodega_med ={3}"
                                                        , bM.Stock,bM.Id_medicina,bM.Id_inventario,bM.Id_bodega_med);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarBodegaMedica(int medicina)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT stock FROM {0} WHERE id_medicina = {1}",
                                     conectar.NombreTabla, medicina);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarBodegaMedica()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM bodega_med order by id_bodega_med";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet bodegaMedicaModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_bodega_med = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public BodegaMedica consultarPorId(int id)
        {

            configuraConexion();

            BodegaMedica auxBodegaMedica = new BodegaMedica();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_bodega_med = {1} order by id_bodega_med",
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
                        auxBodegaMedica.Id_bodega_med = int.Parse(dt.Rows[0]["id_bodega_med"].ToString());
                        auxBodegaMedica.Id_inventario = int.Parse(dt.Rows[0]["id_inventario"].ToString());
                        auxBodegaMedica.Id_medicina = int.Parse(dt.Rows[0]["id_medicina"].ToString());
                        auxBodegaMedica.Stock = int.Parse(dt.Rows[0]["stock"].ToString());
                       
                    }
                    catch (Exception)
                    {
                        auxBodegaMedica.Id_bodega_med = 0;
                        auxBodegaMedica.Id_inventario = 0;
                        auxBodegaMedica.Id_medicina = 0;
                        auxBodegaMedica.Stock = 0;
                       
                    }
                }
            }
            else
            {
                auxBodegaMedica = null;
            }
            return auxBodegaMedica;
        }
    }
}
