using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDeRopas.Model
{
    class Camiseta : Prenda
    {
        //Atributos que guardaran el tipo de Camiseta
        private String _manga;
        private String _cuello;

        //Propiedades
        public string Manga { get => _manga; set => _manga = value; }
        public string Cuello { get => _cuello; set => _cuello = value; }
        //Constructores
        public Camiseta()
        {
        }
        public Camiseta(string manga, string cuello, String calidad, long cant)
        {
            this._manga = manga;
            this._cuello = cuello;
            CalidadPrenda = calidad;
            precioUnitario = 0;
            cantidad = cant;
        }       
    }
}