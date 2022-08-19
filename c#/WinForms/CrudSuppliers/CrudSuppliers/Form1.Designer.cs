namespace CrudSuppliers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEntityFrameworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAdoNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEFWithScaffoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvSuppliersList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSuppliersList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.suppliersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byEntityFrameworkToolStripMenuItem,
            this.byAdoNetToolStripMenuItem,
            this.byEFWithScaffoldToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // byEntityFrameworkToolStripMenuItem
            // 
            this.byEntityFrameworkToolStripMenuItem.Name = "byEntityFrameworkToolStripMenuItem";
            this.byEntityFrameworkToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.byEntityFrameworkToolStripMenuItem.Text = "By Entity Framework";
            this.byEntityFrameworkToolStripMenuItem.Click += new System.EventHandler(this.byEntityFrameworkToolStripMenuItem_Click);
            // 
            // byAdoNetToolStripMenuItem
            // 
            this.byAdoNetToolStripMenuItem.Name = "byAdoNetToolStripMenuItem";
            this.byAdoNetToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.byAdoNetToolStripMenuItem.Text = "By AdoNet";
            this.byAdoNetToolStripMenuItem.Click += new System.EventHandler(this.byAdoNetToolStripMenuItem_Click);
            // 
            // byEFWithScaffoldToolStripMenuItem
            // 
            this.byEFWithScaffoldToolStripMenuItem.Name = "byEFWithScaffoldToolStripMenuItem";
            this.byEFWithScaffoldToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.byEFWithScaffoldToolStripMenuItem.Text = "By EF with scaffold";
            this.byEFWithScaffoldToolStripMenuItem.Click += new System.EventHandler(this.byEFWithScaffoldToolStripMenuItem_Click);
            // 
            // DgvSuppliersList
            // 
            this.DgvSuppliersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSuppliersList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvSuppliersList.Location = new System.Drawing.Point(0, 112);
            this.DgvSuppliersList.Name = "DgvSuppliersList";
            this.DgvSuppliersList.RowHeadersWidth = 62;
            this.DgvSuppliersList.RowTemplate.Height = 33;
            this.DgvSuppliersList.Size = new System.Drawing.Size(800, 338);
            this.DgvSuppliersList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvSuppliersList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSuppliersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem editionToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem byEntityFrameworkToolStripMenuItem;
        private ToolStripMenuItem byAdoNetToolStripMenuItem;
        private DataGridView DgvSuppliersList;
        private ToolStripMenuItem byEFWithScaffoldToolStripMenuItem;
    }
}