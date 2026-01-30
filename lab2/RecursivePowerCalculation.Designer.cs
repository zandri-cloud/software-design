namespace lab2
{
    partial class RecursivePowerCalculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblPowerResult;
            btnPower = new Button();
            label1 = new Label();
            txtExponent = new TextBox();
            txtBase = new TextBox();
            label3 = new Label();
            lblPowerResult = new Label();
            SuspendLayout();
            // 
            // btnPower
            // 
            btnPower.Location = new Point(224, 90);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(75, 23);
            btnPower.TabIndex = 0;
            btnPower.Text = "Calculate";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += btnPower_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Input Exponent";
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(17, 28);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(100, 23);
            txtExponent.TabIndex = 3;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(17, 90);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 67);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Input Base";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(245, 31);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(19, 15);
            lblPowerResult.TabIndex = 2;
            lblPowerResult.Text = "....";
            // 
            // RecursivePowerCalculation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 129);
            Controls.Add(txtBase);
            Controls.Add(label3);
            Controls.Add(txtExponent);
            Controls.Add(lblPowerResult);
            Controls.Add(label1);
            Controls.Add(btnPower);
            Name = "RecursivePowerCalculation";
            Text = "RecursivePowerCalculation";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnPower;
        private Label label1;
        private Label lblPowerResult;
        private TextBox txtExponent;
        private TextBox txtBase;
        private Label label3;
    }
}