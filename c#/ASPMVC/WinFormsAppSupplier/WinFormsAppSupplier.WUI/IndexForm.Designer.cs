namespace WinFormsAppSupplier.WUI
{
    partial class IndexForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homePageTextBox = new System.Windows.Forms.TextBox();
            this.homePageLabel = new System.Windows.Forms.Label();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.faxLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cancelModifyButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.confirmModifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.contactTitleTextBox = new System.Windows.Forms.TextBox();
            this.contactTitleLabel = new System.Windows.Forms.Label();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNameLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AllowUserToAddRows = false;
            this.suppliersDataGridView.AllowUserToDeleteRows = false;
            this.suppliersDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.suppliersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.suppliersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suppliersDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.suppliersDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.suppliersDataGridView.Location = new System.Drawing.Point(0, 298);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            this.suppliersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.suppliersDataGridView.RowTemplate.Height = 25;
            this.suppliersDataGridView.Size = new System.Drawing.Size(1310, 310);
            this.suppliersDataGridView.TabIndex = 36;
            this.suppliersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.homePageTextBox);
            this.groupBox1.Controls.Add(this.homePageLabel);
            this.groupBox1.Controls.Add(this.faxTextBox);
            this.groupBox1.Controls.Add(this.faxLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.cancelModifyButton);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.countryLabel);
            this.groupBox1.Controls.Add(this.postalCodeTextBox);
            this.groupBox1.Controls.Add(this.postalCodeLabel);
            this.groupBox1.Controls.Add(this.regionTextBox);
            this.groupBox1.Controls.Add(this.regionLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.confirmModifyButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(this.cityLabel);
            this.groupBox1.Controls.Add(this.contactTitleTextBox);
            this.groupBox1.Controls.Add(this.contactTitleLabel);
            this.groupBox1.Controls.Add(this.ContactNameTextBox);
            this.groupBox1.Controls.Add(this.ContactNameLabel);
            this.groupBox1.Controls.Add(this.companyNameTextBox);
            this.groupBox1.Controls.Add(this.companyNameLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 280);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // homePageTextBox
            // 
            this.homePageTextBox.Location = new System.Drawing.Point(665, 192);
            this.homePageTextBox.Name = "homePageTextBox";
            this.homePageTextBox.Size = new System.Drawing.Size(271, 29);
            this.homePageTextBox.TabIndex = 49;
            // 
            // homePageLabel
            // 
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homePageLabel.Location = new System.Drawing.Point(503, 188);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(158, 30);
            this.homePageLabel.TabIndex = 48;
            this.homePageLabel.Text = "Page d\'accueil :";
            // 
            // faxTextBox
            // 
            this.faxTextBox.Location = new System.Drawing.Point(665, 149);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(271, 29);
            this.faxTextBox.TabIndex = 47;
            // 
            // faxLabel
            // 
            this.faxLabel.AutoSize = true;
            this.faxLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.faxLabel.Location = new System.Drawing.Point(501, 145);
            this.faxLabel.Name = "faxLabel";
            this.faxLabel.Size = new System.Drawing.Size(56, 30);
            this.faxLabel.TabIndex = 46;
            this.faxLabel.Text = "Fax :";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(665, 106);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(271, 29);
            this.phoneTextBox.TabIndex = 45;
            // 
            // cancelModifyButton
            // 
            this.cancelModifyButton.BackColor = System.Drawing.Color.DarkCyan;
            this.cancelModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelModifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelModifyButton.ForeColor = System.Drawing.Color.White;
            this.cancelModifyButton.Location = new System.Drawing.Point(891, 224);
            this.cancelModifyButton.Name = "cancelModifyButton";
            this.cancelModifyButton.Size = new System.Drawing.Size(160, 50);
            this.cancelModifyButton.TabIndex = 29;
            this.cancelModifyButton.Text = "Annuler";
            this.cancelModifyButton.UseVisualStyleBackColor = false;
            this.cancelModifyButton.Visible = false;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(501, 102);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(50, 30);
            this.phoneLabel.TabIndex = 44;
            this.phoneLabel.Text = "Tel :";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(665, 63);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(271, 29);
            this.countryTextBox.TabIndex = 43;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(501, 59);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(66, 30);
            this.countryLabel.TabIndex = 42;
            this.countryLabel.Text = "Pays :";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(665, 20);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(271, 29);
            this.postalCodeTextBox.TabIndex = 41;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postalCodeLabel.Location = new System.Drawing.Point(501, 16);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(139, 30);
            this.postalCodeLabel.TabIndex = 40;
            this.postalCodeLabel.Text = "Code postal :";
            // 
            // regionTextBox
            // 
            this.regionTextBox.Location = new System.Drawing.Point(217, 235);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(271, 29);
            this.regionTextBox.TabIndex = 39;
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regionLabel.Location = new System.Drawing.Point(6, 231);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(97, 30);
            this.regionLabel.TabIndex = 38;
            this.regionLabel.Text = "Localité :";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(217, 149);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(271, 29);
            this.addressTextBox.TabIndex = 37;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(14, 145);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 30);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "Rue :";
            // 
            // confirmModifyButton
            // 
            this.confirmModifyButton.BackColor = System.Drawing.Color.DarkCyan;
            this.confirmModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmModifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmModifyButton.ForeColor = System.Drawing.Color.White;
            this.confirmModifyButton.Location = new System.Drawing.Point(621, 224);
            this.confirmModifyButton.Name = "confirmModifyButton";
            this.confirmModifyButton.Size = new System.Drawing.Size(160, 50);
            this.confirmModifyButton.TabIndex = 15;
            this.confirmModifyButton.Text = "Appliquer";
            this.confirmModifyButton.UseVisualStyleBackColor = false;
            this.confirmModifyButton.Visible = false;
            this.confirmModifyButton.Click += new System.EventHandler(this.confirmModifyButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkCyan;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(501, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 50);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkCyan;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(776, 224);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 50);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(217, 192);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(271, 29);
            this.cityTextBox.TabIndex = 11;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(14, 188);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(63, 30);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "Ville :";
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.Location = new System.Drawing.Point(217, 106);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(271, 29);
            this.contactTitleTextBox.TabIndex = 8;
            // 
            // contactTitleLabel
            // 
            this.contactTitleLabel.AutoSize = true;
            this.contactTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactTitleLabel.Location = new System.Drawing.Point(14, 102);
            this.contactTitleLabel.Name = "contactTitleLabel";
            this.contactTitleLabel.Size = new System.Drawing.Size(177, 30);
            this.contactTitleLabel.TabIndex = 7;
            this.contactTitleLabel.Text = "Titre du contact :";
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Location = new System.Drawing.Point(217, 63);
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(271, 29);
            this.ContactNameTextBox.TabIndex = 5;
            // 
            // ContactNameLabel
            // 
            this.ContactNameLabel.AutoSize = true;
            this.ContactNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactNameLabel.Location = new System.Drawing.Point(14, 59);
            this.ContactNameLabel.Name = "ContactNameLabel";
            this.ContactNameLabel.Size = new System.Drawing.Size(181, 30);
            this.ContactNameLabel.TabIndex = 4;
            this.ContactNameLabel.Text = "Nom du contact :";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(217, 20);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(271, 29);
            this.companyNameTextBox.TabIndex = 2;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.companyNameLabel.Location = new System.Drawing.Point(14, 16);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(197, 30);
            this.companyNameLabel.TabIndex = 1;
            this.companyNameLabel.Text = "Nom de la société :";
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.Silver;
            this.listButton.Enabled = false;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listButton.ForeColor = System.Drawing.Color.White;
            this.listButton.Location = new System.Drawing.Point(1024, 166);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(160, 50);
            this.listButton.TabIndex = 35;
            this.listButton.Text = "Lister";
            this.listButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Silver;
            this.removeButton.Enabled = false;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(1024, 99);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(160, 50);
            this.removeButton.TabIndex = 34;
            this.removeButton.Text = "Supprimer";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Silver;
            this.modifyButton.Enabled = false;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modifyButton.ForeColor = System.Drawing.Color.White;
            this.modifyButton.Location = new System.Drawing.Point(1024, 32);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(160, 50);
            this.modifyButton.TabIndex = 33;
            this.modifyButton.Text = "Modifier";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 608);
            this.Controls.Add(this.suppliersDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.listButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView suppliersDataGridView;
        private GroupBox groupBox1;
        private Button listButton;
        private Button confirmModifyButton;
        private Button removeButton;
        private Button modifyButton;
        private Button addButton;
        private Button cancelModifyButton;
        private Button searchButton;
        private TextBox cityTextBox;
        private Label cityLabel;
        private TextBox contactTitleTextBox;
        private Label contactTitleLabel;
        private TextBox ContactNameTextBox;
        private Label ContactNameLabel;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private TextBox homePageTextBox;
        private Label homePageLabel;
        private TextBox faxTextBox;
        private Label faxLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox countryTextBox;
        private Label countryLabel;
        private TextBox postalCodeTextBox;
        private Label postalCodeLabel;
        private TextBox regionTextBox;
        private Label regionLabel;
        private TextBox addressTextBox;
        private Label AddressLabel;
    }
}