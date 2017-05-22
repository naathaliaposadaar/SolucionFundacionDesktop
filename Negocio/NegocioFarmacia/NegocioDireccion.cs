using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDireccion
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_direccion = "seq_direccion.nextval";

        public string Seq_direccion
        {
            get
            {
                return _seq_direccion;
            }

            set
            {
                _seq_direccion = value;
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
            Conectar.NombreTabla = "DIRECCION";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarDireccion(Direccion direccion)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_direccion, calle, comuna, cuidad,region,codigopostal) VALUES({1},'{2}','{3}','{4}','{5}',{6})",
                                                   conectar.NombreTabla, Seq_direccion,direccion.Calle,direccion.Comuna,direccion.Ciudad,direccion.Region,direccion.CodigoPostal);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarDireccion(int id)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_direccion = {1}",
                                                  this.conectar.NombreTabla, id);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarDireccion(Direccion direc)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE direccion SET calle='{0}',"
                                                        + " comuna ='{1}',"
                                                        + " cuidad='{2}',"
                                                        + " region='{3}',"
                                                        + " codigopostal={4}"
                                                        + " WHERE id_reccion ={5}"
                                                        , direc.Calle,direc.Comuna,direc.Ciudad,direc.Region,direc.CodigoPostal,direc.Id_direccion);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarDireccion(String calle)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT calle FROM {0} WHERE calle = '{1}'",
                                     conectar.NombreTabla, calle);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarDirecciones()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM direccion order by id_direccion";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet direccionModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_direccion = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public Direccion consultarPorId(int id)
        {

            configuraConexion();

            Direccion auxDireccion = new Direccion();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_direccion = {1} order by id_direccion",
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
                        auxDireccion.Id_direccion = int.Parse(dt.Rows[0]["id_direccion"].ToString());
                        auxDireccion.Calle = dt.Rows[0]["calle"].ToString();
                        auxDireccion.Comuna = dt.Rows[0]["comuna"].ToString();
                        auxDireccion.Ciudad = dt.Rows[0]["ciudad"].ToString();
                        auxDireccion.Region = dt.Rows[0]["region"].ToString();
                        auxDireccion.CodigoPostal = int.Parse(dt.Rows[0]["codigopostal"].ToString());
                        
                    }
                    catch (Exception)
                    {
                        auxDireccion.Id_direccion = 0;
                        auxDireccion.Calle = "";
                        auxDireccion.Comuna = "";
                        auxDireccion.Ciudad = "";
                        auxDireccion.Region = "";
                        auxDireccion.CodigoPostal = 0;
                    }
                }
            }
            else
            {
                auxDireccion = null;
            }
            return auxDireccion;
        }
    }
}
