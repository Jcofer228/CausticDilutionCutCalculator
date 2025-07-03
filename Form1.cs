using System;
using System.Text;
using System.Windows.Forms;

namespace CausticDilutionCutCalculator
{
    public partial class Form1 : Form
    {
        private bool wasCalculated = false;

        public Form1()
        {
            InitializeComponent();

            // Style buttons
            btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            btnCalculate.ForeColor = System.Drawing.Color.White;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            btnClear.BackColor = System.Drawing.Color.SteelBlue;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        }

        private bool TryCalculate()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtV.Text) ||
                    string.IsNullOrWhiteSpace(txtA.Text) ||
                    string.IsNullOrWhiteSpace(txtB.Text) ||
                    string.IsNullOrWhiteSpace(txtC.Text))
                {
                    MessageBox.Show("Please fill in all fields before calculating.");
                    return false;
                }

                double V = double.Parse(txtV.Text);
                double A = double.Parse(txtA.Text);
                double B = double.Parse(txtB.Text);
                double C = double.Parse(txtC.Text);

                if (C == 0)
                {
                    MessageBox.Show("The desired solution percentage (C) cannot be zero.");
                    return false;
                }

                double D = V * A * (B - C) / C;
                lblResult.Text = $"Water needed: {D:F6} gallons";
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numeric values in all fields.");
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("One or more numbers are too large. Please enter smaller values.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
                return false;
            }
        }

        private void txtV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtA.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtB.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtC.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!wasCalculated)
                {
                    if (TryCalculate())
                        wasCalculated = true;
                }
                else
                {
                    ClearAllFields();
                    wasCalculated = false;
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (TryCalculate())
                wasCalculated = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            wasCalculated = false;
        }

        private void ClearAllFields()
        {
            txtV.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            lblResult.Text = "";
            txtV.Focus();
        }
    }
}
