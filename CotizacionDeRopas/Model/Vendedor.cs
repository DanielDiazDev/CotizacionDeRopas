using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionDeRopas.Model
{
    class Vendedor
    {
        //Atributos
        private String _nombre = "Daniel";
        private String _apellido = "Diaz";
        private long _codigoVendedor = 5235523;
        
        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public long CodigoVendedor { get => _codigoVendedor; set => _codigoVendedor = value; }

        //Constructores
        public Vendedor()
        {
        }

        public Vendedor(string nombre, string apellido, long codigoVendedor)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._codigoVendedor = codigoVendedor;
        }
    }

}