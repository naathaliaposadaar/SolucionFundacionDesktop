using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Medicamento
{
    public class Medicina
    {
             
        private int id_medicina;

        public int Id_medicina
        {
            get { return id_medicina; }
            set { id_medicina = value; }
        }
        private string nom_comercial;

        public string Nom_comercial
        {
            get { return nom_comercial; }
            set { nom_comercial = value; }
        }
        private string nom_generico;

        public string Nom_generico
        {
            get { return nom_generico; }
            set { nom_generico = value; }
        }

        private string contenido;
            
        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }
        private string unidad_medida;

        public string Unidad_medida
        {
            get { return unidad_medida; }
            set { unidad_medida = value; }
        }

        private DateTime fec_fabricacion;

        public DateTime Fec_fabricacion
        {
            get { return fec_fabricacion; }
            set { fec_fabricacion = value; }
        }
        private DateTime fec_vencimiento;

        public DateTime Fec_vencimiento
        {
            get { return fec_vencimiento; }
            set { fec_vencimiento = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
             
        
        

      

    }
}
