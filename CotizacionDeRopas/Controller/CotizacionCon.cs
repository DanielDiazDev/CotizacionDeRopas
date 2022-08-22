using CotizacionDeRopas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionDeRopas.Controller
{
    class CotizacionCon
    {
        //Instanciamos
        TiendaDeRopa tienda = new TiendaDeRopa();


        //Metodo para verificar que radio button esta activado 
        public void VerificacionRdPrenda(RadioButton rdCamisa, RadioButton rdPantalon, RadioButton rdCamLarga,
            RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom, RadioButton rdPanChu, RadioButton rdPanCom,
            GroupBox grupTiposPantalon, GroupBox grupCamisaManga, GroupBox grupCamisaCuello)
        {
            if (rdCamisa.Checked)
            {
                grupTiposPantalon.Visible = false;
            }
            else
            {
                grupTiposPantalon.Visible = true;
            }
                
            if (rdPantalon.Checked)
            {
                grupCamisaManga.Visible = false;
                grupCamisaCuello.Visible = false;
            }
            else
            {
                grupCamisaManga.Visible = true;
                grupCamisaCuello.Visible = true;
            }
        }
        //Metodos que carga la cantidad de unidades en stock 
        public void VerificacionCamisa(RadioButton rdCamisa, RadioButton rdCamLarga, RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom, Label unidadesStock, RadioButton rdStandard, RadioButton rdPremium, TextBox txtPreUnit)
        {
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdStandard.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }              
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdStandard.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }               
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdStandard.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }              
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdStandard.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }               
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdPremium.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }             
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdPremium.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }                
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdPremium.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamCorta.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }               
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdPremium.Checked)
            {
                tienda.MostrarUnidadesStockCamisa(rdCamLarga.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }               
        }
        public void VerificacionPantalon(RadioButton rdPantalon, RadioButton rdPanChu, RadioButton rdPanComun, Label unidadesStock, RadioButton rdStandard, RadioButton rdPremium, TextBox txtPreUnit)
        {
            if (rdPantalon.Checked && rdPanComun.Checked && rdStandard.Checked)
            {
                tienda.MostrarUnidadesStockPantalon(rdPanComun.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanChu.Checked && rdStandard.Checked)
            {
                tienda.MostrarUnidadesStockPantalon(rdPanChu.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanComun.Checked && rdPremium.Checked)
            {
                tienda.MostrarUnidadesStockPantalon(rdPanComun.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanChu.Checked && rdPremium.Checked)
            {
                tienda.MostrarUnidadesStockPantalon(rdPanChu.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
                

        }
        //Metodo que cambia el precio unitario de las prendas
        public void PrecioUni(RadioButton rdPantalon, RadioButton rdPanChu, RadioButton rdPanComun, Label unidadesStock, RadioButton rdStandard, RadioButton rdPremium, TextBox txtPreUnit,
           RadioButton rdCamisa, RadioButton rdCamLarga, RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom)
        {
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdStandard.Checked)
            {
                tienda.PCamisa(rdCamCorta.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdStandard.Checked)
            {
                tienda.PCamisa(rdCamLarga.Text, rdCamCom.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdStandard.Checked)
            {
                tienda.PCamisa(rdCamCorta.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdStandard.Checked)
            {
                tienda.PCamisa(rdCamLarga.Text, rdCamMao.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdPremium.Checked)
            {
                tienda.PCamisa(rdCamCorta.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdPremium.Checked)
            {
                tienda.PCamisa(rdCamLarga.Text, rdCamCom.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdPremium.Checked)
            {
                tienda.PCamisa(rdCamCorta.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdPremium.Checked)
            {
                tienda.PCamisa(rdCamLarga.Text, rdCamMao.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanComun.Checked && rdStandard.Checked)
            {
                tienda.PPantalon(rdPanComun.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanChu.Checked && rdStandard.Checked)
            {
                tienda.PPantalon(rdPanChu.Text, rdStandard.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanComun.Checked && rdPremium.Checked)
            {
                tienda.PPantalon(rdPanComun.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }
            if (rdPantalon.Checked && rdPanChu.Checked && rdPremium.Checked)
            {
                tienda.PPantalon(rdPanChu.Text, rdPremium.Text, unidadesStock, txtPreUnit);
            }               
        }
        //Metodo que verifica la cotizacion y la envia a la clase Cotizacion
        public Boolean AnalizarCotizacion(TextBox precioUnitario, TextBox cantidadProductos)
        {
            Double verificar = 0;
            Int32 verCant = 0;
            //Verifico que no esten vacios los campos txt
            if (precioUnitario.Text.Length.Equals(0) || cantidadProductos.Text.Length.Equals(0))
            {
                MessageBox.Show("Posee campos vacios para realizar el calculo", "Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            //Verifico que sea un double y un int los campos txt
            else if (!Double.TryParse(precioUnitario.Text, out verificar) || !Int32.TryParse(cantidadProductos.Text, out verCant))
            {
                precioUnitario.Text = "";
                cantidadProductos.Text = "";
                MessageBox.Show("Datos erroneos precio unitario o cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                //Si toda la verificacion de double y int es correcta guardo los datos
                verificar = Double.Parse(precioUnitario.Text);
                verCant = Int32.Parse(cantidadProductos.Text);
            }
            //Finalmente verifico que sean mayores a 0 ambos
            if (verificar < 0 || verCant < 0)
            {
                precioUnitario.Text = "";
                cantidadProductos.Text = "";
                MessageBox.Show("Datos erroneos precio unitario o cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        //Metodo que envia la lista a verificar
        public Boolean CantPrenda(RadioButton rdPantalon, RadioButton rdPanChu, RadioButton rdPanComun, RadioButton rdStandard, RadioButton rdPremium, TextBox cantPrenda,
          RadioButton rdCamisa, RadioButton rdCamLarga, RadioButton rdCamCorta, RadioButton rdCamMao, RadioButton rdCamCom)
        {
            Boolean verificarCantidad = false;
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdStandard.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamCorta.Text, rdCamCom.Text, rdStandard.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdStandard.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamLarga.Text, rdCamCom.Text, rdStandard.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdStandard.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamCorta.Text, rdCamMao.Text, rdStandard.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdStandard.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamLarga.Text, rdCamMao.Text, rdStandard.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamCom.Checked && rdPremium.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamCorta.Text, rdCamCom.Text, rdPremium.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamCom.Checked && rdPremium.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamLarga.Text, rdCamCom.Text, rdPremium.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamCorta.Checked && rdCamMao.Checked && rdPremium.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamCorta.Text, rdCamMao.Text, rdPremium.Text, cantPrenda);
            }
            if (rdCamisa.Checked && rdCamLarga.Checked && rdCamMao.Checked && rdPremium.Checked)
            {
                verificarCantidad = tienda.CantPrendaCamisa(rdCamLarga.Text, rdCamMao.Text, rdPremium.Text, cantPrenda);
            }
            if (rdPantalon.Checked && rdPanComun.Checked && rdStandard.Checked)
            {
                verificarCantidad = tienda.CantPrendaPantalon(rdPanComun.Text, rdStandard.Text, cantPrenda);
            }
            if (rdPantalon.Checked && rdPanChu.Checked && rdStandard.Checked)
            {
                verificarCantidad = tienda.CantPrendaPantalon(rdPanChu.Text, rdStandard.Text, cantPrenda);
            }
            if (rdPantalon.Checked && rdPanComun.Checked && rdPremium.Checked)
            {
                verificarCantidad = tienda.CantPrendaPantalon(rdPanComun.Text, rdPremium.Text, cantPrenda);
            }

            if (rdPantalon.Checked && rdPanChu.Checked && rdPremium.Checked)
            {
                verificarCantidad = tienda.CantPrendaPantalon(rdPanChu.Text, rdPremium.Text, cantPrenda);
            }
                
            if (verificarCantidad == true)
            {
                MessageBox.Show("La cantidad ingresada es mayor a la que hay disponible", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            return verificarCantidad;
        }

    }

}