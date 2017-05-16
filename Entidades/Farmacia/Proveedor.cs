using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class Proveedor
    {

        private int id_proveedor;
        private string rut_empresa;
        private string razon_social;
        private int id_direccion;

        public int Id_direccion
        {
            get { return id_direccion; }
            set { id_direccion = value; }
        }
        

        public string Razon_social
        {
            get { return razon_social; }
            set { razon_social = value; }
        }
        

        public string Rut_empresa
        {
            get { return rut_empresa; }
            set { rut_empresa = value; }
        }
        

        public int Id_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }
        
    }
}
