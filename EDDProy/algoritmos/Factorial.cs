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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Iniciar cronómetro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Verificamos si el valor ingresado es un número válido
            if (int.TryParse(textBox1.Text, out int numero) && numero >= 0)
            {
                // Calculamos el factorial de forma recursiva
                long resultado = Factorial1(numero);
                // Mostramos el resultado en el Label
                label4.Text = $"EL FACTORIAL DE {numero} ES {resultado}";
            }
            else
            {
                // Mensaje de error si el valor no es válido
                label4.Text = "INGRESA UN NÚMERO VÁLIDO.";
            }

            // Detenemos el cronómetro y mostramos el tiempo transcurrido
            stopwatch.Stop();
            label5.Text = $"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms";
        }

        private long Factorial1(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial1(n - 1);
            }
        }
    }
}
