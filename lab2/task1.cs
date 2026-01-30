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
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtFactorialInput.Text);

                // Prevent stack overflow and long overflow
                if (n < 0)
                    throw new ArgumentException("Factorial cannot be negative.");

                if (n > 67)
                    throw new OverflowException("Input too large. Factorial exceeds long range.");

                long result = Factorial(n);
                lblFactorialResult.Text = $"{result}";
            }
            catch (OverflowException ex)
            {
                lblFactorialResult.Text = ex.Message;
            }
            catch (FormatException)
            {
                lblFactorialResult.Text = "Please enter a valid number.";
            }
            catch (Exception ex)
            {
                lblFactorialResult.Text = $"Error: {ex.Message}";
            }
        }

        private long Factorial(int n)
        {
            if (n == 0)
                return 1; // Base case
            else
                return n * Factorial(n - 1);    
        }

        private void txtFactorialInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFactorialInput_MouseDown(object sender, MouseEventArgs e)
        {
            txtFactorialInput.Clear();

        }
    }
}
