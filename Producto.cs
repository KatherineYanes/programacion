using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
    {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public float Valor { get; set; }
        public float Cambio { get; set; }

        public void sumar(int cantidad)
        {
            this.Cantidad += cantidad;

        }
        public bool valida()

        {
            if (this.Cantidad > 0)
            {
                return true;

            }
            return false;
        }
    }
}