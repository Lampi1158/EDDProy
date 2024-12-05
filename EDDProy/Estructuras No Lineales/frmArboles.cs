using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";



   
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            string graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            Grafica graf = new Grafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
      }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
              // Obtenemos el nodo Raiz del arbol
        miRaiz = miArbol.RegresaRaiz();

        // Validamos que el árbol no esté vacío
        if (miRaiz == null)
        {
            MessageBox.Show("El árbol está vacío");
            return;
        }

        // Convertimos el valor ingresado en la caja de texto a un entero
        int valorABuscar;
        if (int.TryParse(txtDato.Text, out valorABuscar))
        {
            // Llamamos al método de búsqueda
            if (miArbol.Busqueda(valorABuscar, miRaiz))
            {
                lblBusqueda.Text = $"El valor {valorABuscar} fue encontrado en el árbol.";
            }
            else
            {
                lblBusqueda.Text = $"El valor {valorABuscar} no se encuentra en el árbol.";
            }
        }
        else
        {
            MessageBox.Show("Por favor, introduce un número válido.");
        }



        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }
   


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miArbol.PodarTodoElArbol();
            MessageBox.Show("El árbol ha sido podado completamente.");

            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor))
            {
                miRaiz = miArbol.RegresaRaiz();

                
                if (miRaiz == null)
                {
                    MessageBox.Show("El árbol está vacío.");
                    return;
                }

              
                miArbol.eliminarPredecesor(valor, ref miRaiz);

                
                miArbol.strArbol = "";
                miArbol.Muestra(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void btnsucesor_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtDato.Text, out valor))
            {
                miRaiz = miArbol.RegresaRaiz();

                
                if (miRaiz == null)
                {
                    MessageBox.Show("El árbol está vacío.");
                    return;
                }

                
                miArbol.eliminarSucesor(valor, ref miRaiz);

                
                miArbol.strArbol = "";
                miArbol.Muestra(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            miArbol = new ArbolBusqueda(); 
            miRaiz = null; 
            
            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            txtDato.Text = "";

            MessageBox.Show("El árbol ha sido vaciado completamente.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int altura = miArbol.Altura(miRaiz);

            MessageBox.Show($"La altura del árbol es: {altura}");
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            miArbol.strRecorrido = ""; 
            miArbol.RecorridoPorNiveles(miRaiz);

            label5.Text = "Recorrido por niveles: " + miArbol.strRecorrido;
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadHojas = miArbol.ContarHojas(miRaiz);
            MessageBox.Show($"El árbol tiene {cantidadHojas} hojas.");

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadNodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show($"El árbol tiene {cantidadNodos} nodos.");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miArbol.esLleno(miRaiz))
            {
                MessageBox.Show("El árbol es lleno.");
            }
            else
            {
                MessageBox.Show("El árbol NO es lleno.");
            }

            miRaiz = miArbol.RegresaRaiz();
            if (miArbol.esCompleto(miRaiz))
            {
                MessageBox.Show("El árbol es completo.");
            }
            else
            {
                MessageBox.Show("El árbol NO es completo.");
            }
        }
    }
    }
    

