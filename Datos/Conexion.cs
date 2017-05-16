using System;
using System.Windows.Forms;
using System.Data;
using Oracle.DataAccess.Client;

namespace Capa_Conexion
{
    public class Conexion
    {
        private String nombreBaseDeDatos;

        public String NombreBaseDeDatos
        {
            get { return nombreBaseDeDatos; }
            set { nombreBaseDeDatos = value; }
        }

        private String nombreTabla;

        public String NombreTabla
        {
            get { return nombreTabla; }
            set { nombreTabla = value; }
        }

        private String cadenaConexion;

        public String CadenaConexion
        {
            get { return cadenaConexion; }
            set { cadenaConexion = string.Format("DATA SOURCE=nathalia-PC;USER ID=FUNDACION ; password =123"); }
        }

        private String cadenaSQL;

        public String CadenaSQL
        {
            get { return cadenaSQL; }
            set { cadenaSQL = value; }
        }

        private OracleConnection dbConnection;

        public OracleConnection DbConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }

        private DataSet dbDataSet;

        public DataSet DbDataSet
        {
            get { return dbDataSet; }
            set { dbDataSet = value; }
        }

        private OracleDataAdapter dbDataAdapter;

        public OracleDataAdapter DbDataAdapter
        {
            get { return dbDataAdapter; }
            set { dbDataAdapter = value; }
        }

        private Boolean esSelect;

        public Boolean EsSelect
        {
            get { return esSelect; }
            set { esSelect = value; }
        }


        //Abrir la conexion

        public void abrir()
        {
            try
            {
                DbConnection.ConnectionString = cadenaConexion;
                this.DbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Sistema", "Error al abrir la conexion " + ex.Message);
                return;
            } //Fin try abrir
        } // Fin Abrir


        //Metodo cerrar

        public void cerrar()
        {
            try
            {
                this.DbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Sistema", "Error al cerrar la conexion " + ex.Message);
                return;
            } //Fin try cerrar

        }//Fin cerrar

        //Metodo de coneccion

        public int conecta()
        {

            int _resultado = -1;
            //Se validan variables de instancia
            if (this.NombreBaseDeDatos.Length == 0)
            {
                MessageBox.Show("Mensaje Sistema", "Falta Nombre Base de Datos");
                _resultado = -1;
            }

            if (this.NombreTabla.Length == 0)
            {
                MessageBox.Show("Mensaje Sistema", "Falta Nombre Tabla");
                _resultado = -1;
            }

            if (this.CadenaConexion.Length == 0)
            {
                MessageBox.Show("Mensaje Sistema", "Falta Cadena Conexion");
                _resultado = -1;
            }

            if (this.CadenaSQL.Length == 0)
            {
                MessageBox.Show("Mensaje Sistema", "Falta cadena SQL");
                _resultado = -1;
            }

            //Se instancia la conexion

            try
            {
                DbConnection = new OracleConnection(CadenaConexion);
                _resultado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Sistema", "Error de conexion " + ex.Message);
                _resultado = -1;

            } //Fin try conexion

            this.abrir();

            // Preguntar si es Select o no

            if (this.EsSelect)
            {
                //SE carga el dataSet
                DbDataSet = new DataSet();
                try
                {
                    this.DbDataAdapter = new OracleDataAdapter(this.CadenaSQL, this.DbConnection);
                    _resultado = this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el DataSet " + ex.Message, "Mensaje Sistema");
                    _resultado = -1;
                }

            }
            else
            {
                //Se ejecutan las instrucciones INSERT - DELETE- UPDATE
                try
                {

                    OracleCommand variableSQL = new OracleCommand(CadenaSQL, DbConnection);
                    _resultado = variableSQL.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error SQL " + ex.Message, "Mensaje Sistema");
                    _resultado = -1;
                }


            } //Fin if es select
            this.cerrar();
            return _resultado;


        }

    }
}
