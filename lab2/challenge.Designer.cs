namespace lab2
{
    partial class challenge
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            lblFibonacciResult = new Label();
            txtFibonacciInput = new Guna.UI2.WinForms.Guna2TextBox();
            btnFibonacci = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number";
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(12, 77);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(54, 15);
            lblFibonacciResult.TabIndex = 1;
            lblFibonacciResult.Text = "Output:..";
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.CustomizableEdges = customizableEdges1;
            txtFibonacciInput.DefaultText = "";
            txtFibonacciInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFibonacciInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFibonacciInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFibonacciInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFibonacciInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFibonacciInput.Font = new Font("Segoe UI", 9F);
            txtFibonacciInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFibonacciInput.Location = new Point(12, 29);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.PlaceholderText = "";
            txtFibonacciInput.SelectedText = "";
            txtFibonacciInput.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFibonacciInput.Size = new Size(111, 30);
            txtFibonacciInput.TabIndex = 2;
            // 
            // btnFibonacci
            // 
            btnFibonacci.Location = new Point(186, 73);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(75, 23);
            btnFibonacci.TabIndex = 3;
            btnFibonacci.Text = "Factor!";
            btnFibonacci.UseVisualStyleBackColor = true;
            btnFibonacci.Click += btnFibonacci_Click_1;
            // 
            // challenge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 108);
            Controls.Add(btnFibonacci);
            Controls.Add(txtFibonacciInput);
            Controls.Add(lblFibonacciResult);
            Controls.Add(label1);
            Name = "challenge";
            Text = "challenge";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFibonacciResult;
        private Guna.UI2.WinForms.Guna2TextBox txtFibonacciInput;
        private Button btnFibonacci;
    }
}