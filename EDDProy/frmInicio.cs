using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.algoritmos;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_busqueda;
using EDDemo.Metodos_de_ordenamiento;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suma formal = new suma();
            formal.Show();
        }

        private void fACTORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial formal = new Factorial();
            formal.Show();
        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Exponente formal = new Exponente();
            formal.Show();
        }

        private void fibonaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonaccion formal = new Fibonaccion();
            formal.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda formal = new Busqueda();
            formal.Show();
        }

        private void torreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Torre formal = new Torre();
            formal.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cola mPilas = new Cola();
            mPilas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LIstasDobles mPilas = new LIstasDobles();
            mPilas.Show();

        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quitsort mPilas = new Quitsort();
            mPilas.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burbuja mPilas = new Burbuja();
            mPilas.Show();
        }

        private void sellshortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellShort mPilas = new SellShort();
            mPilas.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radix mPilas = new Radix();
            mPilas.Show();
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intercalacion mPilas = new Intercalacion();
            mPilas.Show();
        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MezclaDirecta mPilas = new MezclaDirecta ();
            mPilas.Show();
        }

        private void mezclaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MezclaNatural mPilas = new MezclaNatural();
            mPilas.Show();
        }

        private void biToolStripMenuItem_Click(object sender, EventArgs e)
        {
          BusquedaBinaria mPilas = new BusquedaBinaria();
            mPilas.Show();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaSecuencial mPilas = new BusquedaSecuencial();
            mPilas.Show();
        }
    }
}
