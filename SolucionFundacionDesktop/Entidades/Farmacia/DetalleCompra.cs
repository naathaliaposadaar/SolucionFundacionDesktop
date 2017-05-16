using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class DetalleCompra
    {
        private int id_det_compra;
        private int cantidad;
        private string descripcion;
        private int id_producto;
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        

        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        

        public int Id_det_compra
        {
            get { return id_det_compra; }
            set { id_det_compra = value; }
        }
        
    }
}
