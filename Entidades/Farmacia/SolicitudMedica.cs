using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class SolicitudMedica
    {
        private int id_solic_med;
        private int id_det_solic_med;
        private int id_fic_residente;

        public int Id_fic_residente
        {
            get { return id_fic_residente; }
            set { id_fic_residente = value; }
        }
        


        public int Id_det_solic_med
        {
            get { return id_det_solic_med; }
            set { id_det_solic_med = value; }
        }
        

        public int Id_solic_med
        {
            get { return id_solic_med; }
            set { id_solic_med = value; }
        }
        
    }
}
