using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class Radix : Form
    {
        public Radix()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = txtInput.Text
                    .Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();

                RadixSort(numbers);

                txtOutput.Text = string.Join(", ", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadixSort(int[] array)
        {
            int max = GetMax(array);
            int exp = 1;

            while (max / exp > 0)
            {
                CountingSort(array, exp);
                exp *= 10;
            }
        }

        private void CountingSort(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n]; 
            int[] count = new int[10]; 

            for (int i = 0; i < n; i++)
            {
                int index = (array[i] / exp) % 10;
                count[index]++;
            }
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int index = (array[i] / exp) % 10;
                output[count[index] - 1] = array[i];
                count[index]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }

        private int GetMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}

