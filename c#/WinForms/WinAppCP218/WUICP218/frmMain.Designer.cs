namespace WUICP218
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lireFichierCP218ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lireExcellCP218ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSPProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tSSDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.fileLinesDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.allTabPage = new System.Windows.Forms.TabPage();
            this.errorTabPage = new System.Windows.Forms.TabPage();
            this.errorDataGridView = new System.Windows.Forms.DataGridView();
            this.lenghtErrorTabPage = new System.Windows.Forms.TabPage();
            this.lenghtErrorDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileLinesDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.allTabPage.SuspendLayout();
            this.errorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataGridView)).BeginInit();
            this.lenghtErrorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenghtErrorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lireFichierCP218ToolStripMenuItem,
            this.lireExcellCP218ToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // lireFichierCP218ToolStripMenuItem
            // 
            this.lireFichierCP218ToolStripMenuItem.Name = "lireFichierCP218ToolStripMenuItem";
            this.lireFichierCP218ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lireFichierCP218ToolStripMenuItem.Text = "Lire Fichier CP218";
            this.lireFichierCP218ToolStripMenuItem.Click += new System.EventHandler(this.lireFichierCP218ToolStripMenuItem_Click);
            // 
            // lireExcellCP218ToolStripMenuItem
            // 
            this.lireExcellCP218ToolStripMenuItem.Name = "lireExcellCP218ToolStripMenuItem";
            this.lireExcellCP218ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lireExcellCP218ToolStripMenuItem.Text = "Lire Excel CP218";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSPProgressBar,
            this.tSSDateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSPProgressBar
            // 
            this.tSPProgressBar.Name = "tSPProgressBar";
            this.tSPProgressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // tSSDateLabel
            // 
            this.tSSDateLabel.AutoSize = false;
            this.tSSDateLabel.Name = "tSSDateLabel";
            this.tSSDateLabel.Size = new System.Drawing.Size(483, 17);
            this.tSSDateLabel.Spring = true;
            this.tSSDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fileLinesDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.fileLinesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fileLinesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileLinesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.fileLinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileLinesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLinesDataGridView.GridColor = System.Drawing.Color.Black;
            this.fileLinesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fileLinesDataGridView.Name = "fileLinesDataGridView";
            this.fileLinesDataGridView.RowTemplate.Height = 25;
            this.fileLinesDataGridView.Size = new System.Drawing.Size(786, 370);
            this.fileLinesDataGridView.TabIndex = 2;
            this.fileLinesDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fileLinesDataGridView_RowHeaderMouseDoubleClick);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.allTabPage);
            this.mainTabControl.Controls.Add(this.errorTabPage);
            this.mainTabControl.Controls.Add(this.lenghtErrorTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 404);
            this.mainTabControl.TabIndex = 3;
            this.mainTabControl.Click += new System.EventHandler(this.mainTabControl_Click);
            // 
            // allTabPage
            // 
            this.allTabPage.Controls.Add(this.fileLinesDataGridView);
            this.allTabPage.Location = new System.Drawing.Point(4, 24);
            this.allTabPage.Name = "allTabPage";
            this.allTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allTabPage.Size = new System.Drawing.Size(792, 376);
            this.allTabPage.TabIndex = 0;
            this.allTabPage.Text = "All";
            this.allTabPage.UseVisualStyleBackColor = true;
            // 
            // errorTabPage
            // 
            this.errorTabPage.Controls.Add(this.errorDataGridView);
            this.errorTabPage.Location = new System.Drawing.Point(4, 24);
            this.errorTabPage.Name = "errorTabPage";
            this.errorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.errorTabPage.Size = new System.Drawing.Size(792, 376);
            this.errorTabPage.TabIndex = 1;
            this.errorTabPage.Text = "Error";
            this.errorTabPage.UseVisualStyleBackColor = true;
            // 
            // errorDataGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.errorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.errorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.errorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.errorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorDataGridView.Location = new System.Drawing.Point(3, 3);
            this.errorDataGridView.Name = "errorDataGridView";
            this.errorDataGridView.RowTemplate.Height = 25;
            this.errorDataGridView.Size = new System.Drawing.Size(786, 370);
            this.errorDataGridView.TabIndex = 0;
            this.errorDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.errorFileLinesDataGridView_RowHeaderMouseDoubleClick);
            // 
            // lenghtErrorTabPage
            // 
            this.lenghtErrorTabPage.Controls.Add(this.lenghtErrorDataGridView);
            this.lenghtErrorTabPage.Location = new System.Drawing.Point(4, 24);
            this.lenghtErrorTabPage.Name = "lenghtErrorTabPage";
            this.lenghtErrorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lenghtErrorTabPage.Size = new System.Drawing.Size(792, 376);
            this.lenghtErrorTabPage.TabIndex = 2;
            this.lenghtErrorTabPage.Text = "Lenght error";
            this.lenghtErrorTabPage.UseVisualStyleBackColor = true;
            // 
            // lenghtErrorDataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.lenghtErrorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.lenghtErrorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lenghtErrorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.lenghtErrorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lenghtErrorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lenghtErrorDataGridView.Location = new System.Drawing.Point(3, 3);
            this.lenghtErrorDataGridView.Name = "lenghtErrorDataGridView";
            this.lenghtErrorDataGridView.RowTemplate.Height = 25;
            this.lenghtErrorDataGridView.Size = new System.Drawing.Size(786, 370);
            this.lenghtErrorDataGridView.TabIndex = 0;
            this.lenghtErrorDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.errorFileLinesDataGridView_RowHeaderMouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Gestion des entreprises de la CP218";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileLinesDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.allTabPage.ResumeLayout(false);
            this.errorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorDataGridView)).EndInit();
            this.lenghtErrorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lenghtErrorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem lireFichierCP218ToolStripMenuItem;
        private ToolStripMenuItem lireExcellCP218ToolStripMenuItem;
        private ToolStripMenuItem editionToolStripMenuItem;
        private ToolStripMenuItem affichageToolStripMenuItem;
        private ToolStripProgressBar tSPProgressBar;
        private ToolStripStatusLabel tSSDateLabel;
        private System.Windows.Forms.Timer timerDate;
        private DataGridView fileLinesDataGridView;
        private TabControl mainTabControl;
        private TabPage allTabPage;
        private TabPage errorTabPage;
        private DataGridView errorDataGridView;
        private TabPage lenghtErrorTabPage;
        private DataGridView lenghtErrorDataGridView;
    }
}