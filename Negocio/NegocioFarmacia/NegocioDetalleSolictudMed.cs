using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDetalleSolictudMed
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_dt_sl_med = "seq_dt_sl_med.nextval";

        public string Seq_dt_sl_med
        {
            get
            {
                return _seq_dt_sl_med;
            }

            set
            {
                _seq_dt_sl_med = value;
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
            Conectar.NombreTabla = "DET_SOLICITUD_MED";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarDtSolMed(DetalleSolicitudMedica dtSM)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(ID_DET_SOLIC_MED, motivo, cuidados_espe, estado_solicitud) VALUES({1},'{2}','{3}','{4}')",
                                                   conectar.NombreTabla, Seq_dt_sl_med,dtSM.Motivo,dtSM.Cuidados_espe,dtSM.Estado_solicitud);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarDtSolMed(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE ID_DET_SOLIC_MED = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarDtSolMed(DetalleSolicitudMedica dSM)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE DET_SOLICITUD_MED SET motivo='{0}',"
                                                        + " cuidados_espe ='{1}',"
                                                        + " estado_solicitud='{2}'"
                                                        + " WHERE ID_DET_SOLIC_MED ={3}"
                                                        , dSM.Motivo,dSM.Cuidados_espe,dSM.Estado_solicitud,dSM.Id_det_solic_med);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarDtSolMed(String cuidados_espe)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT estado_solicitud FROM {0} WHERE cuidados_espe = '{1}'",
                                     conectar.NombreTabla, cuidados_espe);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarDtSolMed()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM DET_SOLICITUD_MED order by ID_DET_SOLIC_MED";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet dtSolMedModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_DET_SOLIC_MED = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public DetalleSolicitudMedica consultarPorId(int id)
        {

            configuraConexion();

            DetalleSolicitudMedica auxDSM = new DetalleSolicitudMedica();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_DET_SOLIC_MED = {1} order by ID_DET_SOLIC_MED",
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
                        auxDSM.Id_det_solic_med = int.Parse(dt.Rows[0]["id_det_solic_med"].ToString());
                        auxDSM.Motivo = dt.Rows[0]["motivo"].ToString();
                        auxDSM.Estado_solicitud = dt.Rows[0]["estado_solicitud"].ToString();
                        auxDSM.Cuidados_espe = dt.Rows[0]["cuidados_espe"].ToString();
                        

                    }
                    catch (Exception)
                    {
                        auxDSM.Id_det_solic_med = 0;
                        auxDSM.Motivo = "";
                        auxDSM.Estado_solicitud = "";
                        auxDSM.Cuidados_espe = "";
                    }
                }
            }
            else
            {
                auxDSM = null;
            }
            return auxDSM;
        }
    }
}
