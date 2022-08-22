using CotizacionDeRopas.Controller;
using CotizacionDeRopas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionDeRopas
{
    public partial class Main : Form
    {
        //Instanciamos
        TiendaDeRopa ti = new TiendaDeRopa();
        CotizacionCon con = new CotizacionCon();
        Cotizacion cotiza = new Cotizacion();
        FormDataCon labelel = new FormDataCon();
        HistoriaCotizaciones historia = new HistoriaCotizaciones();//MAnejo el segundo form
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Iniciamos los metodos
            con.PrecioUni(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario, rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun);
            labelel.CambiarDatoLabel(lblNombreTienda, lblDireccionTienda, lblNombreApellido, lblCodigoVendedor);
            con.VerificacionRdPrenda(rdCamisa, rdPantalon, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, rdPantChupin, rdPantComun, grupoPantalon, grupoManga, grupoCuello);
            ti.CargarPrendas();
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            bool verificador = false;
            //Metodo que revisa los textbox de calculo y hace la accion dependiendo lo que suceda
            verificador = con.AnalizarCotizacion(txtPrecioUnitario, txtCantidadPrenda);
            if (verificador == true)
            {
                return;
            }            
            //Metodo que inserta precio unitario
            con.PrecioUni(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario, rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun);
            //Metodo que verifica que la cantidad no sea mayor a la ingresada
            verificador = con.CantPrenda(rdPantalon, rdPantChupin, rdPantComun, rdPrendaStandard, rdPrendaPremium, txtCantidadPrenda, rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun);
            if (verificador == true)
            {
                return;
            }             
            //Guardo fecha y id de cotizacion actual
            cotiza.ModIdFechaYhora();
            //Verifico camisa de entrada para cargar las unidades
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            //Verifico el pantalon seleccionado
            con.VerificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            double precioUnidad = Double.Parse(txtPrecioUnitario.Text);
            Int32 cantidadPrendas = Int32.Parse(txtCantidadPrenda.Text);
            //Metodo que calcula la cotizacion y carga datos en cotizacion
            cotiza.ModificarCodVprendaCantU(precioUnidad, cantidadPrendas, rdPantalon, rdPantChupin, rdPantComun, rdPrendaStandard, rdPrendaPremium, rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, txtTotal);
            //Metodo que carga el DataGridView1 para cargar datos
            cotiza.RellenarDataGridView(historia.dataGridView1);
            txtCantidadPrenda.Text = "";
        }

        private void rdCamisa_CheckedChanged(object sender, EventArgs e)
        {
            //Verifico buttosn para ocultar al hacer click
            con.VerificacionRdPrenda(rdCamisa, rdPantalon, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, rdPantChupin, rdPantComun, grupoPantalon, grupoManga, grupoCuello);
            //Verifico la camisa seleccionada
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPantalon_CheckedChanged(object sender, EventArgs e)
        {
            //Verifico buttosn para ocultar al hacer click
            con.VerificacionRdPrenda(rdCamisa, rdPantalon, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, rdPantChupin, rdPantComun, grupoPantalon, grupoManga, grupoCuello);
            //Verifico el pantalon seleccionado
            con.VerificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdMangaLarga_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPantChupin_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPantComun_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdCamMao_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdCamComun_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void lblLinkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            historia.ShowDialog();
        }

        private void rdPrendaStandard_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            con.VerificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }

        private void rdPrendaPremium_CheckedChanged(object sender, EventArgs e)
        {
            con.VerificacionCamisa(rdCamisa, rdMangaLarga, rdMangaCorta, rdCamMao, rdCamComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
            con.VerificacionPantalon(rdPantalon, rdPantChupin, rdPantComun, lblDisponible, rdPrendaStandard, rdPrendaPremium, txtPrecioUnitario);
        }
    }
}