using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class Producto
    {
        private int id_producto;

        public int Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int id_proveedor;

        public int Id_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }
        
        
       /* ID_PRODUCTO	NUMBER(38,0)
NOMBRE	VARCHAR2(100 BYTE)
CATEGORIA	VARCHAR2(25 BYTE)
TIPO	VARCHAR2(25 BYTE)
PRECIO	NUMBER
ID_PROVEEDOR	NUMBER(38,0)*/
    }
}
