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
    public partial class RecursivePowerCalculation : Form
    {
        public RecursivePowerCalculation()
        {
            InitializeComponent();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNum, exponent;

                if (!int.TryParse(txtBase.Text, out baseNum) ||
                    !int.TryParse(txtExponent.Text, out exponent))
                {
                    throw new FormatException("Invalid number format.");
                }

                if (exponent < 0)
                {
                    throw new ArgumentException("Exponent must be non-negative.");
                }

                if (Math.Abs(baseNum) > 10 && exponent > 18)
                {
                    throw new OverflowException("Result exceeds long data type range.");
                }

                long result = Power(baseNum, exponent);
                lblPowerResult.Text = $"Result: {result}";
            }
            catch (OverflowException ex)
            {
                lblPowerResult.Text = ex.Message;
            }
            catch (FormatException)
            {
                lblPowerResult.Text = "Please enter valid integers.";
            }
            catch (ArgumentException ex)
            {
                lblPowerResult.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblPowerResult.Text = $"Unexpected error: {ex.Message}";
            }
           
        }


        private long Power(int x, int n)
        {
            if (n == 0)
                return 1; 
            return checked(x * Power(x, n - 1));
        }


    }
}
