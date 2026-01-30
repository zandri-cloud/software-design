using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = txtArrayInput.Text
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                int sum = RecursiveSum(numbers, numbers.Length - 1);
                lblSumResult.Text = $"Sum: {sum}";
            }
            catch
            {
                lblSumResult.Text = "Please enter valid comma-separated numbers.";
            }
        }


        private int RecursiveSum(int[] arr, int index)
        {
            if (index < 0)
                return 0;

            return arr[index] + RecursiveSum(arr, index - 1);
        }

    }
}
