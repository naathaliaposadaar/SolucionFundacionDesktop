using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioSolicitudMed
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_solic_med = "seq_solic_med.nextval";

        public string Seq_solic_med
        {
            get
            {
                return _seq_solic_med;
            }

            set
            {
                _seq_solic_med = value;
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
            Conectar.NombreTabla = "SOLIC_MED";
            Conectar.CadenaConexion = "DATA SOURCE=nathalia-PC;USER ID=FUNDACION ; password =123";

        }

        public int ingresarSolicitudMedica(SolicitudMedica solMed, int residente, int dtSM)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_solic_med, id_det_solic_med, id_fic_residente) VALUES({1},{2},{3})",
                                                   conectar.NombreTabla, Seq_solic_med,residente,dtSM);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarSolicitudMedica(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_solic_med = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarSolicitudMedica(SolicitudMedica slMed)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE SOLIC_MED SET ID_DET_SOLIC_MED={0},"
                                                        + " ID_FIC_RESIDENTE ={1}"                                                        
                                                        + " WHERE id_solic_med ={2}"
                                                        , slMed.Id_det_solic_med,slMed.Id_fic_residente,slMed.Id_solic_med);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarSolicitudMedica(int dtSM)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT id_solic_med FROM {0} WHERE ID_DET_SOLIC_MED = {1}",
                                     conectar.NombreTabla, dtSM);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarSolicitudMedica()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM SOLIC_MED order by id_solic_med";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet solMedModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_solic_med = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public SolicitudMedica consultarPorId(int id)
        {

            configuraConexion();

            SolicitudMedica auxSMed = new SolicitudMedica();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_solic_med = {1} order by id_solic_med",
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
                        auxSMed.Id_solic_med = int.Parse(dt.Rows[0]["id_solic_med"].ToString());
                        auxSMed.Id_det_solic_med = int.Parse(dt.Rows[0]["id_det_solic_med"].ToString());
                        auxSMed.Id_fic_residente = int.Parse(dt.Rows[0]["id_fic_residente"].ToString());

                    }
                    catch (Exception)
                    {
                        auxSMed.Id_solic_med = 0;
                        auxSMed.Id_det_solic_med = 0;
                        auxSMed.Id_fic_residente = 0;
                        
                    }
                }
            }
            else
            {
                auxSMed = null;
            }
            return auxSMed;
        }
    }
}
