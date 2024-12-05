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
    public partial class Exponente : Form
    {
        public Exponente()
        {
            InitializeComponent();
        }

        private void Exponente_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Verificamos si los valores ingresados son válidos
            if (double.TryParse(textBoxArreglo.Text, out double baseNumero) &&
                int.TryParse(textBoxExponente.Text, out int exponente) &&
                exponente >= 0)
            {
                // Iniciamos el cronómetro
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Calculamos el exponente de forma recursiva
                double resultado = CalcularExponente(baseNumero, exponente);

                // Detenemos el cronómetro
                stopwatch.Stop();

                // Mostramos el resultado en el Label
                labelResultado.Text = $"{baseNumero}^{exponente} = {resultado}. TIEMPO DE EJECUCIÓN: {stopwatch.ElapsedMilliseconds} ms";
            }
            else
            {
                // Mensaje de error si los valores no son válidos
                labelResultado.Text = "INGRESA NÚMEROS VÁLIDOS";
            }

        }

        // Método recursivo para calcular el exponente
        private double CalcularExponente(double baseNumero, int exponente)
        {
            if (exponente == 0)
            {
                return 1; // Caso base: cualquier número elevado a 0 es 1
            }
            else
            {
                return baseNumero * CalcularExponente(baseNumero, exponente - 1);
            }
        }

    }
}
