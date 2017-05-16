using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class BodegaMedica
    {
        private int id_bodega_med;
        private int id_medicina;
        private int stock;
        private int id_inventario;

        public int Id_inventario
        {
            get { return id_inventario; }
            set { id_inventario = value; }
        }


        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }


        public int Id_medicina
        {
            get { return id_medicina; }
            set { id_medicina = value; }
        }

        public int Id_bodega_med
        {
            get { return id_bodega_med; }
            set { id_bodega_med = value; }
        }

    }
}
