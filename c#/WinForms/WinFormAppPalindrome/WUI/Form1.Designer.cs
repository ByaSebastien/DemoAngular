namespace WUI
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
            this.lstPalindromes = new System.Windows.Forms.ListBox();
            this.btnFileChoices = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtReadText = new System.Windows.Forms.TextBox();
            this.lstPalindromesOK = new System.Windows.Forms.ListBox();
            this.lstPalindromesNOK = new System.Windows.Forms.ListBox();
            this.btnTestAllWords = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPalindromes
            // 
            this.lstPalindromes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalindromes.FormattingEnabled = true;
            this.lstPalindromes.ItemHeight = 15;
            this.lstPalindromes.Location = new System.Drawing.Point(0, 37);
            this.lstPalindromes.Name = "lstPalindromes";
            this.lstPalindromes.Size = new System.Drawing.Size(226, 388);
            this.lstPalindromes.TabIndex = 0;
            // 
            // btnFileChoices
            // 
            this.btnFileChoices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileChoices.Location = new System.Drawing.Point(0, 0);
            this.btnFileChoices.Name = "btnFileChoices";
            this.btnFileChoices.Size = new System.Drawing.Size(226, 37);
            this.btnFileChoices.TabIndex = 1;
            this.btnFileChoices.Text = "Choisir un fichier";
            this.btnFileChoices.UseVisualStyleBackColor = true;
            this.btnFileChoices.Click += new System.EventHandler(this.btnFileChoices_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFileName.Location = new System.Drawing.Point(0, 0);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(454, 54);
            this.txtFileName.TabIndex = 2;
            // 
            // txtReadText
            // 
            this.txtReadText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReadText.Location = new System.Drawing.Point(0, 57);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadText.Size = new System.Drawing.Size(454, 79);
            this.txtReadText.TabIndex = 3;
            // 
            // lstPalindromesOK
            // 
            this.lstPalindromesOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalindromesOK.FormattingEnabled = true;
            this.lstPalindromesOK.ItemHeight = 15;
            this.lstPalindromesOK.Location = new System.Drawing.Point(0, 0);
            this.lstPalindromesOK.Name = "lstPalindromesOK";
            this.lstPalindromesOK.Size = new System.Drawing.Size(150, 250);
            this.lstPalindromesOK.TabIndex = 4;
            // 
            // lstPalindromesNOK
            // 
            this.lstPalindromesNOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalindromesNOK.FormattingEnabled = true;
            this.lstPalindromesNOK.ItemHeight = 15;
            this.lstPalindromesNOK.Location = new System.Drawing.Point(0, 0);
            this.lstPalindromesNOK.Name = "lstPalindromesNOK";
            this.lstPalindromesNOK.Size = new System.Drawing.Size(300, 250);
            this.lstPalindromesNOK.TabIndex = 5;
            // 
            // btnTestAllWords
            // 
            this.btnTestAllWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestAllWords.Location = new System.Drawing.Point(0, 0);
            this.btnTestAllWords.Name = "btnTestAllWords";
            this.btnTestAllWords.Size = new System.Drawing.Size(454, 35);
            this.btnTestAllWords.TabIndex = 6;
            this.btnTestAllWords.Text = "Test tout les mots de la listbox";
            this.btnTestAllWords.UseVisualStyleBackColor = true;
            this.btnTestAllWords.Click += new System.EventHandler(this.btnTestAllWords_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstPalindromes);
            this.splitContainer1.Panel1.Controls.Add(this.btnFileChoices);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(684, 425);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.btnTestAllWords);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtFileName);
            this.splitContainer2.Panel2.Controls.Add(this.txtReadText);
            this.splitContainer2.Size = new System.Drawing.Size(454, 425);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 35);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lstPalindromesOK);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lstPalindromesNOK);
            this.splitContainer3.Size = new System.Drawing.Size(454, 250);
            this.splitContainer3.SplitterDistance = 150;
            this.splitContainer3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Palindrome";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstPalindromes;
        private Button btnFileChoices;
        private TextBox txtFileName;
        private TextBox txtReadText;
        private ListBox lstPalindromesOK;
        private ListBox lstPalindromesNOK;
        private Button btnTestAllWords;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
    }
}