using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDetalleSolicitud
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_det_solic = "seq_det_solic.nextval";

        public string Seq_det_solic
        {
            get
            {
                return _seq_det_solic;
            }

            set
            {
                _seq_det_solic = value;
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
            Conectar.NombreTabla = "DET_SOLICITUD";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarDetSolicitud(DetalleSolicitud dtSol, int medicina)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_det_solicitud, cantidad, fecha, id_medicina) VALUES({1},{2},to_date('{3}','dd/mm/yyyy hh24:mi:ss'),'{4}',{5},{6})",
                                                   conectar.NombreTabla, Seq_det_solic,dtSol.Cantidad,dtSol.Fecha,medicina);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarDetSolicitud(int dtS)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_det_solicitud = {1}",
                                                  this.conectar.NombreTabla, dtS);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarDetSolicirud(DetalleSolicitud dtS)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE det_solicitud SET cantidad={0},"
                                                        + " fecha =to_date('{1}','dd/mm/yyyy hh24:mi:ss',"
                                                        + " id_medicina={2}"                                                        
                                                        + " WHERE id_det_solicitud ={3}"
                                                        , dtS.Cantidad,dtS.Fecha,dtS.Id_medicina,dtS.Id_det_solicitud);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarDetSolicitud(DateTime dtSol)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT cantidad FROM {0} WHERE fecha = to_date('{1}','dd/mm/yyyyy hh24:mi:ss')",
                                     conectar.NombreTabla, dtSol);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarDetSolicitud()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM DET_SOLICITUD order by ID_DET_SOLICITUD";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet DetSolicitudModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_DET_SOLICITUD = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public DetalleSolicitud consultarPorId(int id)
        {

            configuraConexion();

            DetalleSolicitud auxDtS = new DetalleSolicitud();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_DET_SOLICITUD = {1} order by ID_DET_SOLICITUD",
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
                        auxDtS.Id_det_solicitud = int.Parse(dt.Rows[0]["id_det_solicitud"].ToString());
                        auxDtS.Id_medicina = int.Parse(dt.Rows[0]["id_medicina"].ToString());
                        auxDtS.Cantidad = int.Parse(dt.Rows[0]["id_medicina"].ToString());
                        auxDtS.Fecha = DateTime.Parse(dt.Rows[0]["id_medicina"].ToString());
                        

                    }
                    catch (Exception)
                    {
                        auxDtS.Id_det_solicitud = 0;
                        auxDtS.Id_medicina = 0;
                        auxDtS.Cantidad = 0;
                        auxDtS.Fecha = DateTime.Now;
                    }
                }
            }
            else
            {
                auxDtS = null;
            }
            return auxDtS;
        }
    }
}
