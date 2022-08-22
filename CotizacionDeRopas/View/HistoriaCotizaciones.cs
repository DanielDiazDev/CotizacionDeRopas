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
    public partial class HistoriaCotizaciones : Form
    {
        //Atributos
        public DataGridView data = new DataGridView();
        public HistoriaCotizaciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoriaCotizaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
