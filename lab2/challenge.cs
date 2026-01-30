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
    public partial class challenge : Form
    {
        public challenge()
        {
            InitializeComponent();
        }


        private void btnFibonacci_Click(object sender, EventArgs e)
        {
          
        }


        // Recursive Fibonacci Function
        private long Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnFibonacci_Click_1(object sender, EventArgs e)
        {
            int n;

            if (int.TryParse(txtFibonacciInput.Text, out n) && n >= 0)
            {
                long result = Fibonacci(n);
                lblFibonacciResult.Text = $"Fibonacci({n}) = {result}";
            }
            else
            {
                lblFibonacciResult.Text = "Enter a valid non-negative number.";
            }
        }
    }
}
