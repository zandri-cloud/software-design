namespace lab2
{
    partial class task1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtFactorialInput = new Guna.UI2.WinForms.Guna2TextBox();
            btnFactorial = new Guna.UI2.WinForms.Guna2Button();
            lblFactorialResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(97, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Input Number";
            // 
            // txtFactorialInput
            // 
            txtFactorialInput.CustomizableEdges = customizableEdges1;
            txtFactorialInput.DefaultText = "Enter Number";
            txtFactorialInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFactorialInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFactorialInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFactorialInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFactorialInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFactorialInput.Font = new Font("Segoe UI", 9F);
            txtFactorialInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFactorialInput.Location = new Point(12, 41);
            txtFactorialInput.Name = "txtFactorialInput";
            txtFactorialInput.PlaceholderText = "";
            txtFactorialInput.SelectedText = "";
            txtFactorialInput.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFactorialInput.Size = new Size(103, 32);
            txtFactorialInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtFactorialInput.TabIndex = 1;
            txtFactorialInput.TextChanged += txtFactorialInput_TextChanged;
            txtFactorialInput.MouseDown += txtFactorialInput_MouseDown;
            // 
            // btnFactorial
            // 
            btnFactorial.BackColor = SystemColors.ButtonHighlight;
            btnFactorial.CustomizableEdges = customizableEdges3;
            btnFactorial.DisabledState.BorderColor = Color.DarkGray;
            btnFactorial.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFactorial.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFactorial.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFactorial.FillColor = Color.DimGray;
            btnFactorial.Font = new Font("Segoe UI", 9F);
            btnFactorial.ForeColor = Color.White;
            btnFactorial.Location = new Point(148, 41);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFactorial.Size = new Size(132, 32);
            btnFactorial.TabIndex = 2;
            btnFactorial.Text = "Factor";
            btnFactorial.Click += btnFactorial_Click;
            // 
            // lblFactorialResult
            // 
            lblFactorialResult.AutoSize = true;
            lblFactorialResult.Location = new Point(66, 122);
            lblFactorialResult.Name = "lblFactorialResult";
            lblFactorialResult.Size = new Size(19, 15);
            lblFactorialResult.TabIndex = 3;
            lblFactorialResult.Text = "....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Output:";
            // 
            // task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(406, 170);
            Controls.Add(label1);
            Controls.Add(lblFactorialResult);
            Controls.Add(btnFactorial);
            Controls.Add(txtFactorialInput);
            Controls.Add(materialLabel1);
            MaximizeBox = false;
            Name = "task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFactorialInput;
        private Guna.UI2.WinForms.Guna2Button btnFactorial;
        private Label lblFactorialResult;
        private Label label1;
    }
}