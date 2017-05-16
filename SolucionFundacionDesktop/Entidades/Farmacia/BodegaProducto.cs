using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class BodegaProducto
    {
        private int id_bodega_prod;
        private int id_producto;
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
        

        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        
        public int Id_bodega_prod
        {
            get { return id_bodega_prod; }
            set { id_bodega_prod = value; }
        }

    }
}
