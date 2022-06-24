namespace WinFormsFactorial
{
    partial class factorialForm
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
            this.nombreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.calculButton = new System.Windows.Forms.Button();
            this.resultatTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nombreNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreNumericUpDown
            // 
            this.nombreNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreNumericUpDown.Location = new System.Drawing.Point(157, 7);
            this.nombreNumericUpDown.Name = "nombreNumericUpDown";
            this.nombreNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.nombreNumericUpDown.TabIndex = 0;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreLabel.Location = new System.Drawing.Point(13, 9);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(137, 21);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre à calculer";
            // 
            // calculButton
            // 
            this.calculButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculButton.Location = new System.Drawing.Point(13, 52);
            this.calculButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculButton.Name = "calculButton";
            this.calculButton.Size = new System.Drawing.Size(264, 42);
            this.calculButton.TabIndex = 2;
            this.calculButton.Text = "Calculer";
            this.calculButton.UseVisualStyleBackColor = true;
            this.calculButton.Click += new System.EventHandler(this.calculButton_Click);
            // 
            // resultatTextBox
            // 
            this.resultatTextBox.Location = new System.Drawing.Point(13, 112);
            this.resultatTextBox.Name = "resultatTextBox";
            this.resultatTextBox.Size = new System.Drawing.Size(264, 29);
            this.resultatTextBox.TabIndex = 3;
            // 
            // factorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 174);
            this.Controls.Add(this.resultatTextBox);
            this.Controls.Add(this.calculButton);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreNumericUpDown);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "factorialForm";
            this.Text = "Calcul de la factiorielle";
            ((System.ComponentModel.ISupportInitialize)(this.nombreNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nombreNumericUpDown;
        private Label nombreLabel;
        private Button calculButton;
        private TextBox resultatTextBox;
    }
}