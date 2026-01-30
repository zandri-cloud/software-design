namespace lab2
{
    partial class task2
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
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(12, 36);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(100, 23);
            txtArrayInput.TabIndex = 0;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(149, 36);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(75, 23);
            btnCalculateSum.TabIndex = 1;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(12, 95);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(45, 15);
            lblSumResult.TabIndex = 2;
            lblSumResult.Text = "Output";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Input Digit";
            // 
            // task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 143);
            Controls.Add(label2);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Name = "task2";
            Text = "task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
        private Label label2;
    }
}