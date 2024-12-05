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
    public partial class suma : Form
    {
        public suma()
        {
            InitializeComponent();
        }

        // Método para sumar dos arreglos de manera recursiva
        private int[] SumarArreglosRecursivo(int[] arr1, int[] arr2, int index)
        {
            // Caso base: si hemos llegado al final del arreglo, retornamos el resultado
            if (index == arr1.Length)
            {
                return new int[arr1.Length];
            }

            // Sumar los elementos de la posición actual
            int[] resultado = SumarArreglosRecursivo(arr1, arr2, index + 1);
            resultado[index] = arr1[index] + arr2[index];
            return resultado;
        }

        private void buttonsuma_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los arreglos de las entradas de texto
                int[] arreglo1 = textarreglo1.Text.Split(',').Select(int.Parse).ToArray();
                int[] arreglo2 = textarreglo2.Text.Split(',').Select(int.Parse).ToArray();

                // Validar que ambos arreglos tengan el mismo tamaño
                if (arreglo1.Length != arreglo2.Length)
                {
                    labelresultado.Text = "Los arreglos deben tener el mismo tamaño.";
                    return;
                }

                // Iniciar cronómetro
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Llamar al método recursivo para sumar los arreglos
                int[] suma = SumarArreglosRecursivo(arreglo1, arreglo2, 0);

                // Detener cronómetro
                stopwatch.Stop();

                // Mostrar el resultado en el ListBox
                listresultado.Items.Clear();
                foreach (var item in suma)
                {
                    listresultado.Items.Add(item);
                }

                // Mostrar mensaje de éxito con el tiempo transcurrido
                labelresultado.Text = $"Suma completada con éxito. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms";
            }
            catch (Exception ex)
            {
                labelresultado.Text = "Error: " + ex.Message;
            }
        }
    }
            
}
        
    

