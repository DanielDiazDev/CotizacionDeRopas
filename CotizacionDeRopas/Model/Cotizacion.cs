using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionDeRopas.Model
{
    class Cotizacion
    {
        //Atributos
        private long _numeroDeId;
        private String _fechaYhora;
        private long _codigoDelVendedor;
        private String _prendaAcotizar;
        private long _cantDeUnidadesCotizadasPantalon;
        private long _cantDeUnidadesCotizadasCamisa;
        private double _resultadoCotizacion; 
        private DataGridView _internalData = new DataGridView();
        private Vendedor _vende = new Vendedor();

        //Propiedades
        public long NumeroDeId { get => _numeroDeId; set => _numeroDeId = value; }
        public String FechaYhora { get => _fechaYhora; set => _fechaYhora = value; }
        public string PrendaAcotizar { get => _prendaAcotizar; set => _prendaAcotizar = value; }
        public double ResultadoCotizacion { get => _resultadoCotizacion; set => _resultadoCotizacion = value; }
        public long CodigoDelVendedor { get => _codigoDelVendedor; set => _codigoDelVendedor = value; }
        public long CantDeUnidadesCotizadasPantalon { get => _cantDeUnidadesCotizadasPantalon; set => _cantDeUnidadesCotizadasPantalon = value; }
        public long CantDeUnidadesCotizadasCamisa { get => _cantDeUnidadesCotizadasCamisa; set => _cantDeUnidadesCotizadasCamisa = value; }
        public DataGridView InternalData { get => _internalData; set => _internalData = value; }
        protected Vendedor Vende { get => _vende; set => _vende = value; }


        //Constructores
        public Cotizacion()
        {
        }
        public Cotizacion(long numeroDeId, String fechaYhora, long codigoDelVendedor, string prendaAcotizar, long cantDeUnidadesCotizadasPantalon, long cantDeUnidadesCotizadasCamisa, double resultadoCotizacion)
        {
            this._numeroDeId = numeroDeId;
            this._fechaYhora = fechaYhora;
            this._codigoDelVendedor = codigoDelVendedor;
            this._prendaAcotizar = prendaAcotizar;
            this._cantDeUnidadesCotizadasPantalon = cantDeUnidadesCotizadasPantalon;
            this._cantDeUnidadesCotizadasCamisa = cantDeUnidadesCotizadasCamisa;
            this._resultadoCotizacion = resultadoCotizacion;
        }

        
        //Metodo para modificar los descuentos y los texto
        public void ModificarCodVprendaCantU(double precioUnitario, Int32 cantDePrendas,
           RadioButton rdPantalon, RadioButton rdPantChupin, RadioButton rdPantComun, RadioButton rdPrendaStandard, RadioButton rdPrendaPremium,
                RadioButton rdCamisa, RadioButton rdMangaLarga, RadioButton rdMangaCorta, RadioButton rdCamMao, RadioButton rdCamComun, TextBox total)
        {
            double precio = precioUnitario * cantDePrendas;
            //Reglas de negocio
            if (rdCamisa.Checked && rdMangaCorta.Checked)
            {
                precio = precio - (precio / 10); //Descuento 10%
            }
               
            if (rdCamisa.Checked && rdCamMao.Checked)
            {
                precio = precio * 1.03;//Suma 3% 
            }
                
            if (rdPantalon.Checked && rdPantChupin.Checked)
            {
                precio = precio - (precio / 12);//Descuento 12%
            }             
            if (rdCamisa.Checked && rdPrendaPremium.Checked)
            {
                precio = precio * 1.3;//Sumo 30% 
            }              
            if (rdPantalon.Checked && rdPrendaPremium.Checked)
            {
                precio = precio * 1.3;//Sumo 30%
            }
            //Checkea que radio button se apreto y guarda los resultados en texto para el historial
            if (rdPantalon.Checked && rdPantChupin.Checked && rdPrendaStandard.Checked)
            {
                this._prendaAcotizar = rdPantalon.Text + " - " + rdPantChupin.Text + " - " + rdPrendaStandard.Text;
                this._cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdPantalon.Checked && rdPantChupin.Checked && rdPrendaPremium.Checked)
            {
                this._prendaAcotizar = rdPantalon.Text + " - " + rdPantChupin.Text + " - " + rdPrendaPremium.Text;
                this._cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdPantalon.Checked && rdPantComun.Checked && rdPrendaStandard.Checked)
            {
                this._prendaAcotizar = rdPantalon.Text + " - " + rdPantComun.Text + " - " + rdPrendaStandard.Text;
                this._cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdPantalon.Checked && rdPantComun.Checked && rdPrendaPremium.Checked)
            {
                this._prendaAcotizar = rdPantalon.Text + " - " + rdPantComun.Text + " - " + rdPrendaPremium.Text;
                this._cantDeUnidadesCotizadasPantalon = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaCorta.Checked && rdPrendaStandard.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamComun.Text + " - " + rdMangaCorta.Text + " - " + rdPrendaStandard.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaCorta.Checked && rdPrendaPremium.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamComun.Text + " - " + rdMangaCorta.Text + " - " + rdPrendaPremium.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaLarga.Checked && rdPrendaStandard.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamComun.Text + " - " + rdMangaLarga.Text + " - " + rdPrendaStandard.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamComun.Checked && rdMangaLarga.Checked && rdPrendaPremium.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamComun.Text + " - " + rdMangaLarga.Text + " - " + rdPrendaPremium.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaCorta.Checked && rdPrendaStandard.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamMao.Text + " - " + rdMangaCorta.Text + " - " + rdPrendaStandard.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaCorta.Checked && rdPrendaPremium.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamMao.Text + " - " + rdMangaCorta.Text + " - " + rdPrendaPremium.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaLarga.Checked && rdPrendaStandard.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamMao.Text + " - " + rdMangaLarga.Text + " - " + rdPrendaStandard.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            if (rdCamisa.Checked && rdCamMao.Checked && rdMangaLarga.Checked && rdPrendaPremium.Checked)
            {
                this._prendaAcotizar = rdCamisa.Text + " - " + rdCamMao.Text + " - " + rdMangaLarga.Text + " - " + rdPrendaPremium.Text;
                this._cantDeUnidadesCotizadasCamisa = cantDePrendas;
            }
            total.Text = precio.ToString();
            this._resultadoCotizacion = precio;
            this._codigoDelVendedor = Vende.CodigoVendedor;
        }
        //Metodo para modificar fecha y hora cada vez que cotizamos
        public void ModIdFechaYhora()
        {
            this._fechaYhora = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            long num = 1;
            this._numeroDeId = (num + this._numeroDeId);

        }
        //Metodo que rellena el DataGridView
        public void RellenarDataGridView(DataGridView datos)
        {

            long numID = NumeroDeId;
            String fecha = FechaYhora;
            long codVendedor = CodigoDelVendedor;
            String prendaCotizar = PrendaAcotizar;
            long cantCamisa = CantDeUnidadesCotizadasCamisa;
            long cantPantalon = CantDeUnidadesCotizadasPantalon;
            double total = ResultadoCotizacion;
            try
            {
                datos.Rows.Add(numID, fecha, codVendedor, prendaCotizar, cantCamisa, cantPantalon, total);
            }
            catch(Exception e)
            {
                string error = e.Message;
                MessageBox.Show(error);
               
            }
            
            this.InternalData = datos;
        }

    }
}