using Capa_Conexion;
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioProveedor
    {
        //objeto clase Conexion
        private Conexion conectar;
        //secuencia id
        private string _seq_prooveedor = "seq_prooveedor.nextval";

        public string Seq_prooveedor
        {
            get
            {
                return _seq_prooveedor;
            }

            set
            {
                _seq_prooveedor = value;
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
            Conectar.NombreTabla = "PROVEEDOR";
            Conectar.CadenaConexion = "DATA SOURCE=localhost;USER ID=FUNDACION ; password =123";

        }

        public int ingresarProveedor(Proveedor prov, int direccion)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("INSERT INTO {0}(id_proveedor, razon_social, rut_empresa,id_direccion) VALUES({1},'{2}','{3}',{4})",
                                                   conectar.NombreTabla, Seq_prooveedor,prov.Razon_social,prov.Rut_empresa,prov.Id_direccion);


            conectar.EsSelect = false;
            return conectar.conecta();

        }


        public int eliminarProveedor(int prove)
        {

            this.configuraConexion();
            this.conectar.CadenaSQL = string.Format("DELETE FROM {0} WHERE id_proveedor = {1}",
                                                  this.conectar.NombreTabla, prove);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }





        public int actualizarProveedor(Proveedor prov)
        {
            this.configuraConexion();
            this.conectar.CadenaSQL = String.Format("UPDATE proveedor SET id_direccion={0},"
                                                        + " razon_social ='{1}',"
                                                        + " rut_empresa='{2}'"                                                       
                                                        + " WHERE id_proveedor ={3}"
                                                        , prov.Id_direccion,prov.Rut_empresa,prov.Rut_empresa,prov.Id_proveedor);
            this.conectar.EsSelect = false;
            return this.conectar.conecta();
        }


        public int consultarProveedor(String prov)
        {
            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT razon_social FROM {0} WHERE rut_empresa = '{1}'",
                                     conectar.NombreTabla, prov);
            conectar.EsSelect = true;
            return conectar.conecta();
        }

        public System.Data.DataSet listarProveedor()
        {

            configuraConexion();
            conectar.CadenaSQL = "SELECT * FROM PROVEEDOR order by ID_PROVEEDOR";
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }

        public System.Data.DataSet proveedorModificado(int id)
        {

            configuraConexion();
            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE ID_PROVEEDOR = '{1}'",
                                    conectar.NombreTabla, id);
            conectar.EsSelect = true;
            conectar.conecta();

            return conectar.DbDataSet;
        }
        public Proveedor consultarPorId(int id)
        {

            configuraConexion();

            Proveedor auxProveedor = new Proveedor();

            conectar.CadenaSQL = String.Format("SELECT * FROM {0} WHERE id_proveedor = {1} order by id_proveedor",
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
                        auxProveedor.Id_proveedor = int.Parse(dt.Rows[0]["id_proveedor"].ToString());
                        auxProveedor.Id_direccion = int.Parse(dt.Rows[0]["id_direccion"].ToString());
                        auxProveedor.Rut_empresa = dt.Rows[0]["rut_empresa"].ToString();
                        auxProveedor.Razon_social = dt.Rows[0]["rut_empresa"].ToString();                      

                    }
                    catch (Exception)
                    {
                        auxProveedor.Id_proveedor = 0;
                        auxProveedor.Id_direccion = 0;
                        auxProveedor.Rut_empresa = "";
                        auxProveedor.Razon_social = "";
                    }
                }
            }
            else
            {
                auxProveedor = null;
            }
            return auxProveedor;
        }
    }
}
