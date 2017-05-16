using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class DetalleSolicitud
    {

        private int id_det_solicitud;
        private DateTime fecha;
        private int cantidad;
        private int id_medicina;

        public int Id_medicina
        {
            get { return id_medicina; }
            set { id_medicina = value; }
        }
        

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public int Id_det_solicitud
        {
            get { return id_det_solicitud; }
            set { id_det_solicitud = value; }
        }
        
    }
}
