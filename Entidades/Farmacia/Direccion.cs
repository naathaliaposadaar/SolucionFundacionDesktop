using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class Direccion
    {


        private int id_direccion;
        private string calle;
        private string comuna;
        private string ciudad;
        private string region;
        private int codigopostal;

        public int CodigoPostal
        {
            get { return codigopostal; }
            set { codigopostal = value; }
        }
        

        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        

        public string Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        

        public int Id_direccion
        {
            get { return id_direccion; }
            set { id_direccion = value; }
        }
        
    }
}
