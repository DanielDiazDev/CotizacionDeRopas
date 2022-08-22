using CotizacionDeRopas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionDeRopas.Controller
{
    class FormDataCon
    {
        //Atributos
        private TiendaDeRopa _tienda = new TiendaDeRopa();
        private Vendedor _vende = new Vendedor();
        //Constructores
        public FormDataCon()
        {
        }
        //Metodo label completo que cambia los datos
        public void CambiarDatoLabel(Label nomTienda, Label dirTienda, Label nomVendedor, Label codVendedor)
        {
            nomTienda.Text = $"Nombre tienda: {_tienda.Nombre}";
            dirTienda.Text = $"Dir: {_tienda.Direccion}";
            nomVendedor.Text = $"Nombre: {_vende.Nombre} {_vende.Apellido}";
            codVendedor.Text = $"Codigo vendedor: {_vende.CodigoVendedor}";
        }
    }
}