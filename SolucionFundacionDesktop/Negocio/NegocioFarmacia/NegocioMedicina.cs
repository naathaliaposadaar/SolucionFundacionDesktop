using Capa_Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Medicamento;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioMedicina
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_medicina = "seq_medicina.nextval";

        public string Seq_Medicina
        {
            get
            {
                return _seq_medicina;
            }

            set
            {
                _seq_medicina = value;
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
            Conectar.NombreTabla = "MEDICINA";
            Conectar.CadenaConexion = "DATA SOURCE=nathalia-PC;USER ID=FUNDACION ; password =123";

        }

         public int ingresarMedicina(Medicina medicina)
        {
      
            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_medicina, nom_comercial, nom_generico, contenido,unidad_medida,fec_fabricacion,fec_vencimiento,cantidad,descripcion) VALUES({1},'{2}','{3}','{4}','{5}',TO_DATE('{6}','dd/mm/yyyy hh24:mi:ss'),TO_DATE('{7}','dd/mm/yyyy hh24:mi:ss'),{8},'{9}')",
                                                   conectar.NombreTabla, Seq_Medicina, medicina.Nom_comercial, medicina.Nom_generico, medicina.Contenido, medicina.Unidad_medida, medicina.Fec_fabricacion, medicina.Fec_vencimiento, medicina.Cantidad, medicina.Descripcion);
            //conectar.CadenaSQL = String.Format("exec PR_IN_UP_MEDICINA({0},'{1}','{2}','{3}','{4}',{5},{6},{7},'{8}')",medicina.Id_medicina, medicina.Nom_comercial,medicina.Nom_generico,medicina.Contenido,medicina.Unidad_medida,medicina.Fec_fabricacion,medicina.Fec_vencimiento,medicina.Cantidad,medicina.Descripcion);
             
             conectar.EsSelect = false;
            return conectar.conecta();

        }

        
        public int eliminarMedicamento(int medicamento)
        {
            //PR_ELIMINAR_MEDICINA
            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_medicina = {1}",
                                                  this.conectar.NombreTabla, medicamento);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


       
        

        public int actualizarMedicina(Medicina med)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE medicina SET cantidad={0},"
                                                        +" NOM_GENERICO ='{1}',"
                                                        +" CONTENIDO='{2}',"
                                                        +" UNIDAD_MEDIDA='{3}',"
                                                        + " FEC_FABRICACION=TO_DATE('{4}','dd/mm/yyyy hh24:mi:ss'),"
                                                        + " FEC_VENCIMIENTO=TO_DATE('{5}','dd/mm/yyyy hh24:mi:ss'),"
                                                        +" DESCRIPCION='{6}'"
                                                        +" WHERE id_medicina ={7}"
                                                        , med.Cantidad, med.Nom_generico, med.Contenido, med.Unidad_medida, med.Fec_fabricacion, med.Fec_vencimiento, med.Descripcion,med.Id_medicina);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }

        
        public int consultarMedicina(String medicina)
        {           
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT nom_comercial FROM {0} WHERE nom_comercial = '{1}'",
                                     conectar.NombreTabla, medicina);
            conectar.EsSelect = true;
            return conectar.conecta();
        }
       
         public System.Data.DataSet listarMedicinas()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM MEDICINA order by ID_MEDICINA";
            //SELECT MED.ID_MEDICINA,MED.NOM_COMERCIAL,MED.NOM_GENERICO,MED.CONTENIDO,MED.UNIDAD_MEDIDA,MED.FEC_FABRICACION,MED.FEC_VENCIMIENTO,MED.CANTIDAD,MED.DESCRIPCION FROM MEDICINA MED
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        //Lista por MedicinaModificada
         public System.Data.DataSet medicinaModificada(int id)
         {

             configuraConexion();
             conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_medicina = '{1}'",
                                     conectar.NombreTabla, id);
             conectar.EsSelect = true;
             conectar.conecta();

             return conectar.DbDataSet;
         }
         public Medicina consultarPorIdMedicina(int id)
         {

             configuraConexion();

             Medicina auxMedicina = new Medicina();

             conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_medicina = {1} order by ID_MEDICINA",
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
                         auxMedicina.Id_medicina = int.Parse(dt.Rows[0]["id_medicina"].ToString());
                         auxMedicina.Nom_comercial = dt.Rows[0]["nom_comercial"].ToString();
                         auxMedicina.Nom_generico = dt.Rows[0]["nom_generico"].ToString();
                         auxMedicina.Unidad_medida = dt.Rows[0]["unidad_medida"].ToString();
                         auxMedicina.Fec_fabricacion = DateTime.Parse(dt.Rows[0]["fec_fabricacion"].ToString());
                         auxMedicina.Fec_vencimiento = DateTime.Parse(dt.Rows[0]["fec_vencimiento"].ToString());
                         auxMedicina.Contenido = dt.Rows[0]["contenido"].ToString();
                         auxMedicina.Cantidad = int.Parse(dt.Rows[0]["cantidad"].ToString());
                         auxMedicina.Descripcion = dt.Rows[0]["descripcion"].ToString();

                     }
                     catch (Exception)
                     {
                         auxMedicina.Id_medicina = 0;
                         auxMedicina.Nom_comercial = "";
                         auxMedicina.Nom_generico = "";
                         auxMedicina.Unidad_medida = "";
                         auxMedicina.Fec_fabricacion = DateTime.Now;
                         auxMedicina.Fec_vencimiento = DateTime.Now;
                         auxMedicina.Contenido = "";
                         auxMedicina.Cantidad = 0;
                         auxMedicina.Descripcion = "";
                     }
                 }
             }
             else
             {
                 auxMedicina = null;
             }
             return auxMedicina;
         }


    }
    
}
