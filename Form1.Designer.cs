namespace CausticDilutionCutCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(206, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 45);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Caustic Dilution Cut Calulator\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblV
            // 
            this.lblV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(140, 176);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(260, 23);
            this.lblV.TabIndex = 23;
            this.lblV.Text = "V - Gallons of Strong Caustic in Tank";
            this.lblV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtV
            // 
            this.txtV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtV.Location = new System.Drawing.Point(609, 176);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(120, 26);
            this.txtV.TabIndex = 24;
            this.txtV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtV_KeyDown);
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(140, 226);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(264, 23);
            this.lblA.TabIndex = 25;
            this.lblA.Text = "A - Specific Gravity of Strong Caustic";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(609, 226);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 26);
            this.txtA.TabIndex = 26;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtA_KeyDown);
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(140, 278);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(280, 23);
            this.lblB.TabIndex = 27;
            this.lblB.Text = "B - Concentration of Strong Caustic (%)";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(609, 278);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 26);
            this.txtB.TabIndex = 28;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(140, 332);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(336, 23);
            this.lblC.TabIndex = 29;
            this.lblC.Text = "C - Concentration of the Solution You Want (%)\r\n";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(609, 332);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(120, 26);
            this.txtC.TabIndex = 30;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtC_KeyDown);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(144, 406);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(322, 54);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "Calculate Water Needed";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblResult.Location = new System.Drawing.Point(166, 529);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(529, 40);
            this.lblResult.TabIndex = 32;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(556, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 54);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(867, 668);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caustic Dilution ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
    }
}

