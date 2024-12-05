using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        MiPila miPila = new MiPila();


        public frmPilas()
        {
            InitializeComponent();
        }

       

        private void btnPush_Click_1(object sender, EventArgs e)
        {
            MiNodo unNuevonodo = new MiNodo();
            unNuevonodo.Nombre = textBox1.Text;
            miPila.aplicar(unNuevonodo);
            Mostrarpila();

            MessageBox.Show("Se ingreso el NOMBRE a la pila!");
        }

        void Mostrarpila()
        {
            listBox1.Items.Clear();
            if (miPila != null)
            {
                MostrarNodoEnlista(miPila.Tope());
            }
        }

        void MostrarNodoEnlista(MiNodo unNodo)
        {
            listBox1.Items.Add(unNodo.Nombre);
            if (unNodo.siguiente != null)
            {
                MostrarNodoEnlista(unNodo.siguiente);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            miPila.desaplilar();
            Mostrarpila();
            MessageBox.Show("Se elimino correctamente el dato!");
        }
    }
}
