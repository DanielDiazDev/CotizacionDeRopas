using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionDeRopas.Model
{
    class TiendaDeRopa
    {
        //Atributos
        private String _nombre = "Look Shop";
        private String _direccion = "Av. Irigoyen 357, Caleta Olivia";
        private static List<Pantalon> _listaPantalon = new List<Pantalon>();
        private static List<Camiseta> _listaCamiseta = new List<Camiseta>();
        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public List<Pantalon> ListaPantalon { get => _listaPantalon; set => _listaPantalon = value; }
        public List<Camiseta> ListaCamisetas { get => _listaCamiseta; set => _listaCamiseta = value; }

        public TiendaDeRopa()
        {
        }
        //Metodo que carga las listas con stock al comienzo del programa
        public void CargarPrendas()
        {
            this.ListaCamisetas.Add(new Camiseta("Larga", "Común", "Standard", 175));
            this.ListaCamisetas.Add(new Camiseta("Larga", "Común", "Premium", 175));
            this.ListaCamisetas.Add(new Camiseta("Larga", "Mao", "Standard", 75));
            this.ListaCamisetas.Add(new Camiseta("Larga", "Mao", "Premium", 75));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Común", "Standard", 150));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Común", "Premium", 150));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Mao", "Standard", 100));
            this.ListaCamisetas.Add(new Camiseta("Corta", "Mao", "Premium", 100));
            this.ListaPantalon.Add(new Pantalon("Chupin", "Standard", 750));
            this.ListaPantalon.Add(new Pantalon("Chupin", "Premium", 750));
            this.ListaPantalon.Add(new Pantalon("Común", "Standard", 250));
            this.ListaPantalon.Add(new Pantalon("Común", "Premium", 250));
        }      
        //Metodos que mostrara las unidades en stock de las prendas
        public void MostrarUnidadesStockCamisa(String manga, String cuello, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {

            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].Manga.Equals(manga) && this.ListaCamisetas[i].Cuello.Equals(cuello) && this.ListaCamisetas[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long can = this.ListaCamisetas[i].Cantidad;
                    double pre = this.ListaCamisetas[i].PrecioUnitario;
                    preUnit.Text = pre.ToString();
                    unidadesStock.Text = "" + can;
                }
            }

        }
        public void MostrarUnidadesStockPantalon(String tipoPantalon, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {
            for (int i = 0; i < this.ListaPantalon.Count; i++)
            {
                if (this.ListaPantalon[i].TipoPantalon.Equals(tipoPantalon) && this.ListaPantalon[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long can = this.ListaPantalon[i].Cantidad;
                    double pre = this.ListaPantalon[i].PrecioUnitario;
                    preUnit.Text = pre.ToString();
                    unidadesStock.Text = "" + can;
                }
            }
        }
        //Metodos que cambia el precio unitario de las prendas
        public void PCamisa(String manga, String cuello, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {
            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].Manga.Equals(manga) && this.ListaCamisetas[i].Cuello.Equals(cuello) && this.ListaCamisetas[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    this.ListaCamisetas[i].PrecioUnitario = double.Parse(preUnit.Text);
                }
            }
        }
        public void PPantalon(String tipoPantalon, String calidadPrenda, Label unidadesStock, TextBox preUnit)
        {
            for (int i = 0; i < this.ListaPantalon.Count; i++)
            {
                if (this.ListaPantalon[i].TipoPantalon.Equals(tipoPantalon) && this.ListaPantalon[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    this.ListaPantalon[i].PrecioUnitario = double.Parse(preUnit.Text);
                }
            }
        }
        //Metodo que verifica que la cantidad  ingresada no sea mayor al stock
        public Boolean CantPrendaCamisa(String manga, String cuello, String calidadPrenda, TextBox cantPrenda)
        {
            for (int i = 0; i < this.ListaCamisetas.Count; i++)
            {
                if (this.ListaCamisetas[i].Manga.Equals(manga) && this.ListaCamisetas[i].Cuello.Equals(cuello) && this.ListaCamisetas[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long cant = this.ListaCamisetas[i].Cantidad;
                    long cantP = Int32.Parse(cantPrenda.Text);
                    if (cant < cantP)
                    {
                        return true;
                    }
                        
                }
            }
            return false;
        }
        public Boolean CantPrendaPantalon(String tipoPantalon, String calidadPrenda, TextBox cantPrenda)
        {
            for (int i = 0; i < this.ListaPantalon.Count; i++)
            {
                if (this.ListaPantalon[i].TipoPantalon.Equals(tipoPantalon) && this.ListaPantalon[i].CalidadPrenda.Equals(calidadPrenda))
                {
                    long cant = this.ListaPantalon[i].Cantidad;
                    long cantP = Int32.Parse(cantPrenda.Text);
                    if (cant < cantP)
                    {
                        return true;
                    }                       
                }
            }
            return false;
        }
    }
}