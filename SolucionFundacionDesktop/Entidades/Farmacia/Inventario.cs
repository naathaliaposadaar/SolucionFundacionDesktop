using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class Inventario
    {
        private int id_inventario;
        private int cantidad_productos;
        private DateTime fecha_inventario;
        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        

        public DateTime Fecha_inventario
        {
            get { return fecha_inventario; }
            set { fecha_inventario = value; }
        }


        public int Cantidad_productos
        {
            get { return cantidad_productos; }
            set { cantidad_productos = value; }
        }
        

        public int Id_inventario
        {
            get { return id_inventario; }
            set { id_inventario = value; }
        }
        
    }
}
