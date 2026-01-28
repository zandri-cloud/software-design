namespace lab1Descending
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSort = new MaterialSkin.Controls.MaterialButton();
            DigitsListBox = new MaterialSkin.Controls.MaterialListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSort.Depth = 0;
            btnSort.HighEmphasis = true;
            btnSort.Icon = null;
            btnSort.Location = new Point(57, 133);
            btnSort.Margin = new Padding(4, 6, 4, 6);
            btnSort.MouseState = MaterialSkin.MouseState.HOVER;
            btnSort.Name = "btnSort";
            btnSort.NoAccentTextColor = Color.Empty;
            btnSort.Size = new Size(64, 36);
            btnSort.TabIndex = 2;
            btnSort.Text = "sort";
            btnSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSort.UseAccentColor = false;
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // DigitsListBox
            // 
            DigitsListBox.BackColor = Color.White;
            DigitsListBox.BorderColor = Color.LightGray;
            DigitsListBox.Depth = 0;
            DigitsListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            DigitsListBox.Location = new Point(195, 117);
            DigitsListBox.MouseState = MaterialSkin.MouseState.HOVER;
            DigitsListBox.Name = "DigitsListBox";
            DigitsListBox.SelectedIndex = -1;
            DigitsListBox.SelectedItem = null;
            DigitsListBox.Size = new Size(573, 312);
            DigitsListBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DigitsListBox);
            Controls.Add(btnSort);
            FormStyle = FormStyles.ActionBar_56;
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(3, 80, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSort;
        private MaterialSkin.Controls.MaterialListBox DigitsListBox;
    }
}
