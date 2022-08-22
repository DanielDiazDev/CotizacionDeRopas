using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDeRopas.Model
{
    abstract class Prenda
    {
        //Atributos que seran llamados desde las clases hijas
        protected String calidadPrenda;
        protected double precioUnitario;
        protected long cantidad;
        //Propiedades
        public string CalidadPrenda { get => calidadPrenda; set => calidadPrenda = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public long Cantidad { get => cantidad; set => cantidad = value; }
    }
}