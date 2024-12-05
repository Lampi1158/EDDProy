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
    public partial class Torre : Form
    {
        public Torre()
        {
            InitializeComponent();
        }
        // Método recursivo para resolver la Torre de Hanoi
        private void TorreDeHanoi(int n, char origen, char destino, char auxiliar)
        {
            if (n == 1)
            {
                // Movimiento base: mover un solo disco
                listBoxMovimiento.Items.Add($"Mover disco 1 de {origen} a {destino}");
                return;
            }

            // Mover n-1 discos desde el origen hasta el auxiliar usando el destino como auxiliar
            TorreDeHanoi(n - 1, origen, auxiliar, destino);

            // Mover el disco n desde el origen hasta el destino
            listBoxMovimiento.Items.Add($"Mover disco {n} de {origen} a {destino}");

            // Mover los n-1 discos desde el auxiliar hasta el destino usando el origen como auxiliar
            TorreDeHanoi(n - 1, auxiliar, destino, origen);
        }
        private void buttonResolver_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número de discos desde el TextBox
                int numeroDiscos = int.Parse(textBoxNumeroDiscos.Text);

                // Limpiar el ListBox de movimientos anteriores
                listBoxMovimiento.Items.Clear();

                // Iniciar cronómetro
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Llamar al método recursivo de la Torre de Hanoi
                TorreDeHanoi(numeroDiscos, 'A', 'C', 'B');

                // Detener cronómetro
                stopwatch.Stop();

                // Mensaje de éxito
                labelResultado.Text = $"Resolución completada con éxito. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Error: " + ex.Message;
            }
        }
    }
}
