using NLayer.Entidades;
using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayerFormulario1
{
    public partial class Form1 : Form
    {        

        private TipoPrestamoNegocio _tipos;
        

        public Form1(TipoPrestamoNegocio tp)
        {
            this._tipos = tp;
            InitializeComponent();
            
        }

        private void CargarTiposPrestamo(List<TipoPrestamo> listaTiposPrestamo)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listaTiposPrestamo;
        }



            private void Form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(this._tipos.TraerTipoPrestamos());


             }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}