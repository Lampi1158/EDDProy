using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class BusquedaSecuencial : Form
    {
        public BusquedaSecuencial()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = txtInput.Text
                    .Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();

                int target = int.Parse(txtTarget.Text);

                int position = SequentialSearch(numbers, target);

                if (position != -1)
                {
                    txtOutput.Text = $"Número {target} encontrado en la posición {position}.";
                }
                else
                {
                    txtOutput.Text = $"Número {target} no encontrado.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int SequentialSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; 
                }
            }

            return -1; 
        }
    }
}
