using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDeRopas.Model
{
    class Pantalon : Prenda
    {
        //Atributos que guardaran el tipo de pantalon
        private String _tipoPantalon;
        //Propiedades
        public string TipoPantalon { get => _tipoPantalon; set => _tipoPantalon = value; }
        //Constructores
        public Pantalon()
        {
        }
        public Pantalon(string tipoPantalon, String calidadPrenda, long stock)
        {
            this._tipoPantalon = tipoPantalon;
            this.CalidadPrenda = calidadPrenda;
            cantidad = stock;
            precioUnitario = 0;
        }       
    }
}