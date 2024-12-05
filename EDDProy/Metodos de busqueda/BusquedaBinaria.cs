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
    public partial class BusquedaBinaria : Form
    {
        public BusquedaBinaria()
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

                Array.Sort(numbers);

                int target = int.Parse(txtTarget.Text);

                int position = BinarySearch(numbers, target);

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

        private int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                {
                    return mid; 
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1; 
                }
            }

            return -1; 
        }
    }
}

