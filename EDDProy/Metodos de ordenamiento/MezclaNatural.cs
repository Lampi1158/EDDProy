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
    public partial class MezclaNatural : Form
    {
        public MezclaNatural()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void MezclaNatural_Load(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = txtInput.Text
                    .Split(',')
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();

                numbers = NaturalMergeSort(numbers);

                txtOutput.Text = string.Join(", ", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[] NaturalMergeSort(int[] array)
        {
            while (true)
            {
                List<List<int>> runs = DetectRuns(array);

                if (runs.Count <= 1)
                    break;

                List<int> merged = new List<int>();
                for (int i = 0; i < runs.Count; i += 2)
                {
                    if (i + 1 < runs.Count)
                        merged.AddRange(Merge(runs[i], runs[i + 1]));
                    else
                        merged.AddRange(runs[i]);
                }

                array = merged.ToArray();
            }

            return array;
        }

        private List<List<int>> DetectRuns(int[] array)
        {
            List<List<int>> runs = new List<List<int>>();
            List<int> currentRun = new List<int> { array[0] };

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    currentRun.Add(array[i]);
                }
                else
                {
                    runs.Add(currentRun);
                    currentRun = new List<int> { array[i] };
                }
            }

            runs.Add(currentRun);
            return runs;
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
                result.Add(left[i++]);
            while (j < right.Count)
                result.Add(right[j++]);

            return result;
        }
    }
}

