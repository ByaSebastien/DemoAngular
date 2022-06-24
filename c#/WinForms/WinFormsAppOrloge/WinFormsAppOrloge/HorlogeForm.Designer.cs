namespace WinFormsAppOrloge
{
    partial class HorlogeForm
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
            this.components = new System.ComponentModel.Container();
            this.txtWatch = new System.Windows.Forms.TextBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tmrWatch = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWatch
            // 
            this.txtWatch.BackColor = System.Drawing.Color.Gold;
            this.txtWatch.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWatch.ForeColor = System.Drawing.Color.Red;
            this.txtWatch.Location = new System.Drawing.Point(12, 12);
            this.txtWatch.Name = "txtWatch";
            this.txtWatch.Size = new System.Drawing.Size(268, 93);
            this.txtWatch.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Black;
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(12, 111);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(268, 41);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.UseVisualStyleBackColor = false;
            // 
            // tmrWatch
            // 
            this.tmrWatch.Interval = 1000;
            this.tmrWatch.Tick += new System.EventHandler(this.tmrWatch_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 29);
            //this.textBox1.TabIndex = 2;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 29);
            //this.textBox2.TabIndex = 3;
            //this.textBox2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 251);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(268, 38);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Affichage";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // HorlogeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 308);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.txtWatch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HorlogeForm";
            this.Text = "Horloge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HorlogeForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtWatch;
        private Button btnStartStop;
        private System.Windows.Forms.Timer tmrWatch;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnDisplay;
    }
}