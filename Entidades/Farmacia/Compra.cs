using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class Compra
    {
        private int id_compra;
        private string descripcion;
        private int montototal;
        private DateTime fecha;
        private int id_det_compra;

        public int Id_det_compra
        {
            get { return id_det_compra; }
            set { id_det_compra = value; }
        }
        

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

        public int MontoTotal
        {
            get { return montototal; }
            set { montototal = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public int Id_compra
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        
    }
}
