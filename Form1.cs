/*
 * Caustic Dilution Cut Calculator
 * Author: Jeffrey Cofer
 * Created: July 2, 2025
 * 
 * This application calculates the volume of water required to dilute a caustic solution
 * from a given concentration to a desired lower concentration.
 */

using System;
using System.Text;
using System.Windows.Forms;

namespace CausticDilutionCutCalculator
{
    public partial class Form1 : Form
    {
        private bool wasCalculated = false; // Tracks whether a calculation was recently performed

        public Form1()
        {
            InitializeComponent();
            StyleButtons();
        }

        /// <summary>
        /// Applies styling to the Calculate and Clear buttons for consistent UI.
        /// </summary>
        private void StyleButtons()
        {
            btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            btnCalculate.ForeColor = System.Drawing.Color.White;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            btnClear.BackColor = System.Drawing.Color.SteelBlue;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        }

        /// <summary>
        /// Attempts to perform the dilution calculation.
        /// Returns true if successful, false if input is invalid or an error occurs.
        /// </summary>
        private bool TryCalculate()
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtV.Text) ||
                    string.IsNullOrWhiteSpace(txtA.Text) ||
                    string.IsNullOrWhiteSpace(txtB.Text) ||
                    string.IsNullOrWhiteSpace(txtC.Text))
                {
                    MessageBox.Show("Please fill in all fields before calculating.");
                    return false;
                }

                // Parse inputs
                double V = double.Parse(txtV.Text); // Volume of caustic solution in gallons
                double A = double.Parse(txtA.Text); // Strength (% active) of caustic being added
                double B = double.Parse(txtB.Text); // % concentration of existing solution
                double C = double.Parse(txtC.Text); // Desired % concentration after dilution

                // Check for division by zero
                if (C == 0)
                {
                    MessageBox.Show("The desired solution percentage (C) cannot be zero.");
                    return false;
                }

                // Calculation formula: D = V * A * (B - C) / C
                double D = V * A * (B - C) / C;

                // Display result
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

        /// <summary>
        /// Clears all input fields and resets result label.
        /// </summary>
        private void ClearAllFields()
        {
            txtV.Clear();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            lblResult.Text = "";
            txtV.Focus();
        }

        // Event handlers for key navigation using Enter key

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

        // Button click events

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
    }
}
