namespace WordDocGen.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._bGenerate = new System.Windows.Forms.Button();
            this._tbAssignment = new System.Windows.Forms.TextBox();
            this._lSubject = new System.Windows.Forms.Label();
            this._lAssignment = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this._msMain = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identitySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verktygToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._cbSubject = new System.Windows.Forms.ComboBox();
            this._msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bGenerate
            // 
            this._bGenerate.Location = new System.Drawing.Point(282, 34);
            this._bGenerate.Name = "_bGenerate";
            this._bGenerate.Size = new System.Drawing.Size(191, 23);
            this._bGenerate.TabIndex = 2;
            this._bGenerate.Text = "Skapa dokument";
            this._bGenerate.UseVisualStyleBackColor = true;
            this._bGenerate.Click += new System.EventHandler(this.genButtonClick);
            // 
            // _tbAssignment
            // 
            this._tbAssignment.Location = new System.Drawing.Point(55, 36);
            this._tbAssignment.Name = "_tbAssignment";
            this._tbAssignment.Size = new System.Drawing.Size(191, 20);
            this._tbAssignment.TabIndex = 0;
            this._tbAssignment.Text = "Uppgift";
            this._tbAssignment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownSelectNext);
            // 
            // _lSubject
            // 
            this._lSubject.AutoSize = true;
            this._lSubject.Location = new System.Drawing.Point(12, 65);
            this._lSubject.Name = "_lSubject";
            this._lSubject.Size = new System.Drawing.Size(37, 13);
            this._lSubject.TabIndex = 9;
            this._lSubject.Text = "Ämne:";
            this._lSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lAssignment
            // 
            this._lAssignment.AutoSize = true;
            this._lAssignment.Location = new System.Drawing.Point(5, 39);
            this._lAssignment.Name = "_lAssignment";
            this._lAssignment.Size = new System.Drawing.Size(44, 13);
            this._lAssignment.TabIndex = 10;
            this._lAssignment.Text = "Uppgift:";
            this._lAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // _msMain
            // 
            this._msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.verktygToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._msMain.Location = new System.Drawing.Point(0, 0);
            this._msMain.Name = "_msMain";
            this._msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._msMain.Size = new System.Drawing.Size(485, 24);
            this._msMain.TabIndex = 12;
            this._msMain.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderSettingsToolStripMenuItem,
            this.identitySettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.settingsToolStripMenuItem.Text = "Inställningar";
            // 
            // folderSettingsToolStripMenuItem
            // 
            this.folderSettingsToolStripMenuItem.Name = "folderSettingsToolStripMenuItem";
            this.folderSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.folderSettingsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.folderSettingsToolStripMenuItem.Text = "Användarinställningar...";
            this.folderSettingsToolStripMenuItem.Click += new System.EventHandler(this.folderSettingsToolStripMenuItem_Click);
            // 
            // identitySettingsToolStripMenuItem
            // 
            this.identitySettingsToolStripMenuItem.Name = "identitySettingsToolStripMenuItem";
            this.identitySettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.identitySettingsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.identitySettingsToolStripMenuItem.Text = "Ämnen...";
            this.identitySettingsToolStripMenuItem.Click += new System.EventHandler(this.identitySettingsToolStripMenuItem_Click);
            // 
            // verktygToolStripMenuItem
            // 
            this.verktygToolStripMenuItem.Name = "verktygToolStripMenuItem";
            this.verktygToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.verktygToolStripMenuItem.Text = "Verktyg";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Hjälp";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.helpToolStripMenuItem1.Text = "Hjälp...";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // _cbSubject
            // 
            this._cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSubject.FormattingEnabled = true;
            this._cbSubject.Location = new System.Drawing.Point(55, 62);
            this._cbSubject.Name = "_cbSubject";
            this._cbSubject.Size = new System.Drawing.Size(191, 21);
            this._cbSubject.TabIndex = 1;
            this._cbSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownSelectNext);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 103);
            this.Controls.Add(this._cbSubject);
            this.Controls.Add(this._msMain);
            this.Controls.Add(this._lAssignment);
            this.Controls.Add(this._lSubject);
            this.Controls.Add(this._tbAssignment);
            this.Controls.Add(this._bGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this._msMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Dokument Generator X2000";
            this._msMain.ResumeLayout(false);
            this._msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bGenerate;
        private System.Windows.Forms.TextBox _tbAssignment;
        private System.Windows.Forms.Label _lSubject;
        private System.Windows.Forms.Label _lAssignment;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip _msMain;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identitySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ComboBox _cbSubject;
        private System.Windows.Forms.ToolStripMenuItem verktygToolStripMenuItem;
    }
}

