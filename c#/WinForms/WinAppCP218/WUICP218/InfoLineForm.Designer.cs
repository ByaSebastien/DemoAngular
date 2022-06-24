namespace WUI
{
    partial class InfoLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.naceCodeTextBox = new System.Windows.Forms.TextBox();
            this.employeesNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.iDToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.sendingCVDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.frenchRadioButton = new System.Windows.Forms.RadioButton();
            this.nederlandsRadioButton = new System.Windows.Forms.RadioButton();
            this.unknowRadioButton = new System.Windows.Forms.RadioButton();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.dutchRadioButton = new System.Windows.Forms.RadioButton();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.languageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(24, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(766, 29);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(24, 137);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(766, 29);
            this.addressTextBox.TabIndex = 3;
            this.addressTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(304, 214);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(485, 29);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(24, 214);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(260, 29);
            this.postalCodeTextBox.TabIndex = 5;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nace code";
            // 
            // naceCodeTextBox
            // 
            this.naceCodeTextBox.Location = new System.Drawing.Point(24, 291);
            this.naceCodeTextBox.Name = "naceCodeTextBox";
            this.naceCodeTextBox.Size = new System.Drawing.Size(260, 29);
            this.naceCodeTextBox.TabIndex = 8;
            this.naceCodeTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // employeesNumberComboBox
            // 
            this.employeesNumberComboBox.FormattingEnabled = true;
            this.employeesNumberComboBox.Location = new System.Drawing.Point(304, 291);
            this.employeesNumberComboBox.Name = "employeesNumberComboBox";
            this.employeesNumberComboBox.Size = new System.Drawing.Size(483, 29);
            this.employeesNumberComboBox.TabIndex = 11;
            this.employeesNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Taille entreprise";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(231, 412);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(163, 73);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "CONFIRMER";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(430, 412);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(163, 73);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // iDToolStripStatusLabel
            // 
            this.iDToolStripStatusLabel.Name = "iDToolStripStatusLabel";
            this.iDToolStripStatusLabel.Size = new System.Drawing.Size(805, 17);
            this.iDToolStripStatusLabel.Spring = true;
            this.iDToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date envoi CV";
            // 
            // sendingCVDateTimePicker
            // 
            this.sendingCVDateTimePicker.Location = new System.Drawing.Point(24, 368);
            this.sendingCVDateTimePicker.Name = "sendingCVDateTimePicker";
            this.sendingCVDateTimePicker.Size = new System.Drawing.Size(260, 29);
            this.sendingCVDateTimePicker.TabIndex = 18;
            // 
            // frenchRadioButton
            // 
            this.frenchRadioButton.AutoSize = true;
            this.frenchRadioButton.Location = new System.Drawing.Point(6, 28);
            this.frenchRadioButton.Name = "frenchRadioButton";
            this.frenchRadioButton.Size = new System.Drawing.Size(66, 25);
            this.frenchRadioButton.TabIndex = 19;
            this.frenchRadioButton.TabStop = true;
            this.frenchRadioButton.Text = "Frans";
            this.frenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // nederlandsRadioButton
            // 
            this.nederlandsRadioButton.AutoSize = true;
            this.nederlandsRadioButton.Location = new System.Drawing.Point(92, 28);
            this.nederlandsRadioButton.Name = "nederlandsRadioButton";
            this.nederlandsRadioButton.Size = new System.Drawing.Size(108, 25);
            this.nederlandsRadioButton.TabIndex = 20;
            this.nederlandsRadioButton.TabStop = true;
            this.nederlandsRadioButton.Text = "Nederlands";
            this.nederlandsRadioButton.UseVisualStyleBackColor = true;
            // 
            // unknowRadioButton
            // 
            this.unknowRadioButton.AutoSize = true;
            this.unknowRadioButton.Location = new System.Drawing.Point(397, 28);
            this.unknowRadioButton.Name = "unknowRadioButton";
            this.unknowRadioButton.Size = new System.Drawing.Size(84, 25);
            this.unknowRadioButton.TabIndex = 21;
            this.unknowRadioButton.TabStop = true;
            this.unknowRadioButton.Text = "Inconnu";
            this.unknowRadioButton.UseVisualStyleBackColor = true;
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Location = new System.Drawing.Point(220, 28);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(73, 25);
            this.englishRadioButton.TabIndex = 22;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "Engels";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // dutchRadioButton
            // 
            this.dutchRadioButton.AutoSize = true;
            this.dutchRadioButton.Location = new System.Drawing.Point(313, 28);
            this.dutchRadioButton.Name = "dutchRadioButton";
            this.dutchRadioButton.Size = new System.Drawing.Size(64, 25);
            this.dutchRadioButton.TabIndex = 23;
            this.dutchRadioButton.TabStop = true;
            this.dutchRadioButton.Text = "Duits";
            this.dutchRadioButton.UseVisualStyleBackColor = true;
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.frenchRadioButton);
            this.languageGroupBox.Controls.Add(this.dutchRadioButton);
            this.languageGroupBox.Controls.Add(this.nederlandsRadioButton);
            this.languageGroupBox.Controls.Add(this.englishRadioButton);
            this.languageGroupBox.Controls.Add(this.unknowRadioButton);
            this.languageGroupBox.Location = new System.Drawing.Point(306, 329);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(484, 68);
            this.languageGroupBox.TabIndex = 24;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "Langue";
            this.languageGroupBox.Enter += new System.EventHandler(this.languageGroupBox_Enter);
            // 
            // InfoLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 517);
            this.Controls.Add(this.languageGroupBox);
            this.Controls.Add(this.sendingCVDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.employeesNumberComboBox);
            this.Controls.Add(this.naceCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoLineForm";
            this.Text = "Fiche signalétique d\'entreprise";
            this.Load += new System.EventHandler(this.InfoLineForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.languageGroupBox.ResumeLayout(false);
            this.languageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox addressTextBox;
        private TextBox cityTextBox;
        private Label label3;
        private TextBox postalCodeTextBox;
        private Label label4;
        private TextBox naceCodeTextBox;
        private ComboBox employeesNumberComboBox;
        private Label label6;
        private Button confirmButton;
        private Button cancelButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel iDToolStripStatusLabel;
        private Label label7;
        private DateTimePicker sendingCVDateTimePicker;
        private RadioButton frenchRadioButton;
        private RadioButton nederlandsRadioButton;
        private RadioButton unknowRadioButton;
        private RadioButton englishRadioButton;
        private RadioButton dutchRadioButton;
        private GroupBox languageGroupBox;
    }
}