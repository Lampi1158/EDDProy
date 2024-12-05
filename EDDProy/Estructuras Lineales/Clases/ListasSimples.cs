using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public partial class ListasSimples : Form
    {
        private listasimple lista;
        public ListasSimples()
        {
            InitializeComponent();
            lista = new listasimple();
        }

        private void ActualizarLista()
        {
            listLista.Items.Clear();
            foreach (int dato in lista.ObtenerLista())
            {
                listLista.Items.Add(dato);
            }
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                lista.AgregarInicio(dato);
                ActualizarLista();
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                lista.AgregarFinal(dato);
                ActualizarLista();
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            lista.EliminarInicio();
            ActualizarLista();
        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            lista.EliminarFinal();
            ActualizarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                bool encontrado = lista.Buscar(dato);
                MessageBox.Show(encontrado ? "Dato encontrado en la lista." : "Dato no encontrado.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
