using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class DetalleSolicitudMedica
    {

        private int id_det_solic_med;
        private string estado_solicitud;
        private string motivo;
        private string cuidados_espe;

        public string Cuidados_espe
        {
            get { return cuidados_espe; }
            set { cuidados_espe = value; }
        }
        

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        

        public string Estado_solicitud
        {
            get { return estado_solicitud; }
            set { estado_solicitud = value; }
        }
        

        public int Id_det_solic_med
        {
            get { return id_det_solic_med; }
            set { id_det_solic_med = value; }
        }
        
    }
}
