using EDDemo.Estructuras_Lineales.Clases;
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

namespace EDDemo.Estructuras_Lineales
{
    public partial class Cola : Form
    {

        cola2 miCola = new cola2();
        public Cola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre!");
            }
            else
            {
                MiNodo unNuevoNuevo = new MiNodo();
                unNuevoNuevo.Nombre = textBox1.Text;
                miCola.encolar(unNuevoNuevo);
                MostrarCola();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (miCola.Vacia())
            {
                MessageBox.Show("La cola esta vacia!");
            }
            else
            {
                miCola.desencolar();
                MostrarCola();
            }
        }

        private void MostrarCola()
        {
            listBox1.Items.Clear();
            MostrarNodo(miCola.inicio);


        }

        private void MostrarNodo(MiNodo unNodo)
        {
            if (unNodo != null)
            {
                listBox1.Items.Add(unNodo.Nombre);


                if (unNodo.siguiente != null)
                {
                    MostrarNodo(unNodo.siguiente);
                }


            }



        }
    }
}
