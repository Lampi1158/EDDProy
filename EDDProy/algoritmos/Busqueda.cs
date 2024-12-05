using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.algoritmos
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        // Método recursivo para realizar la búsqueda binaria
        private int BusquedaBinariaRecursiva(int[] arreglo, int numero, int izquierda, int derecha)
        {
            if (izquierda > derecha)
            {
                return -1; // No encontrado
            }

            int medio = (izquierda + derecha) / 2;

            if (arreglo[medio] == numero)
            {
                return medio; // Encontrado
            }
            else if (arreglo[medio] > numero)
            {
                return BusquedaBinariaRecursiva(arreglo, numero, izquierda, medio - 1); // Buscar en la izquierda
            }
            else
            {
                return BusquedaBinariaRecursiva(arreglo, numero, medio + 1, derecha); // Buscar en la derecha
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el input del TextBox en un arreglo de enteros y ordenar el arreglo
                int[] arreglo = textBoxArreglo.Text.Split(',').Select(int.Parse).OrderBy(x => x).ToArray();

                // Convertir el número a buscar
                int numero = int.Parse(textBoxNumero.Text);

                // Iniciar el cronómetro
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Ejecutar la búsqueda binaria recursiva
                int indice = BusquedaBinariaRecursiva(arreglo, numero, 0, arreglo.Length - 1);

                // Detener el cronómetro
                stopwatch.Stop();

                // Mostrar el resultado
                if (indice != -1)
                {
                    labelResultado.Text = $"Número encontrado en el índice {indice}. Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
                }
                else
                {
                    labelResultado.Text = $"Número no encontrado. Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Error: " + ex.Message;
            }

        }
    }
}
