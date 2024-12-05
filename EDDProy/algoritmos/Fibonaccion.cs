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
    public partial class Fibonaccion : Form
    {
        public Fibonaccion()
        {
            InitializeComponent();
        }


        // Método recursivo para calcular la secuencia de Fibonacci de un número
        private int FibonacciRecursivo(int n)
        {
            if (n <= 1) return n; // Caso base: Fibonacci(0) = 0 y Fibonacci(1) = 1
            return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
        }

        // Método recursivo para aplicar Fibonacci a cada número del arreglo
        private int[] FibonacciArregloRecursivo(int[] arreglo, int index)
        {
            if (index == arreglo.Length)
            {
                return new int[arreglo.Length];
            }

            // Aplicar Fibonacci recursivamente a cada número del arreglo
            int[] resultado = FibonacciArregloRecursivo(arreglo, index + 1);
            resultado[index] = FibonacciRecursivo(arreglo[index]);
            return resultado;
        }


        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el input del TextBox en un arreglo de enteros
                int[] arreglo = textBoxArreglo.Text.Split(',').Select(int.Parse).ToArray();

                // Iniciar cronómetro
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Calcular la secuencia de Fibonacci para cada número en el arreglo
                int[] resultado = FibonacciArregloRecursivo(arreglo, 0);

                // Detener cronómetro
                stopwatch.Stop();

                // Mostrar el resultado en el ListBox
                listBoxResultado.Items.Clear();
                foreach (var item in resultado)
                {
                    listBoxResultado.Items.Add(item);
                }

                // Mostrar mensaje de éxito con el tiempo transcurrido
                labelResultado.Text = $"Cálculo completado con éxito. Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Error: " + ex.Message;
            }

        }
    }
}
