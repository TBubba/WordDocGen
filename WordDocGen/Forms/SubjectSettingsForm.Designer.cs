namespace WordDocGen.Forms
{
    partial class SubjectSettingsForm
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
            this._bAccept = new System.Windows.Forms.Button();
            this._msMain = new System.Windows.Forms.MenuStrip();
            this._tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._tmsiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this._tssEdit1 = new System.Windows.Forms.ToolStripSeparator();
            this._tmsiEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this._lbSubjects = new System.Windows.Forms.ListBox();
            this._tbSubject = new System.Windows.Forms.TextBox();
            this._lSubject = new System.Windows.Forms.Label();
            this._lFolder = new System.Windows.Forms.Label();
            this._tbFolder = new System.Windows.Forms.TextBox();
            this._bFindPath = new System.Windows.Forms.Button();
            this._fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this._msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bAccept
            // 
            this._bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._bAccept.Location = new System.Drawing.Point(222, 386);
            this._bAccept.Name = "_bAccept";
            this._bAccept.Size = new System.Drawing.Size(163, 23);
            this._bAccept.TabIndex = 7;
            this._bAccept.Text = "Verkställ";
            this._bAccept.UseVisualStyleBackColor = true;
            this._bAccept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _msMain
            // 
            this._msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiEdit});
            this._msMain.Location = new System.Drawing.Point(0, 0);
            this._msMain.Name = "_msMain";
            this._msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._msMain.Size = new System.Drawing.Size(392, 24);
            this._msMain.TabIndex = 13;
            this._msMain.Text = "menuStrip1";
            this._msMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _tsmiEdit
            // 
            this._tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tmsiAdd,
            this._tsmiRemove,
            this._tssEdit1,
            this._tmsiEmpty});
            this._tsmiEdit.Name = "_tsmiEdit";
            this._tsmiEdit.Size = new System.Drawing.Size(48, 20);
            this._tsmiEdit.Text = "Ändra";
            // 
            // _tmsiAdd
            // 
            this._tmsiAdd.Name = "_tmsiAdd";
            this._tmsiAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this._tmsiAdd.Size = new System.Drawing.Size(179, 22);
            this._tmsiAdd.Text = "Lägg till";
            this._tmsiAdd.Click += new System.EventHandler(this._msiAdd_Click);
            // 
            // _tsmiRemove
            // 
            this._tsmiRemove.Name = "_tsmiRemove";
            this._tsmiRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._tsmiRemove.Size = new System.Drawing.Size(179, 22);
            this._tsmiRemove.Text = "Ta bort";
            this._tsmiRemove.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // _tssEdit1
            // 
            this._tssEdit1.Name = "_tssEdit1";
            this._tssEdit1.Size = new System.Drawing.Size(176, 6);
            // 
            // _tmsiEmpty
            // 
            this._tmsiEmpty.Name = "_tmsiEmpty";
            this._tmsiEmpty.Size = new System.Drawing.Size(179, 22);
            this._tmsiEmpty.Text = "Töm...";
            this._tmsiEmpty.Click += new System.EventHandler(this._msiEmpty_Click);
            // 
            // _lbSubjects
            // 
            this._lbSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbSubjects.FormattingEnabled = true;
            this._lbSubjects.Location = new System.Drawing.Point(12, 27);
            this._lbSubjects.Name = "_lbSubjects";
            this._lbSubjects.Size = new System.Drawing.Size(201, 381);
            this._lbSubjects.TabIndex = 0;
            this._lbSubjects.SelectedIndexChanged += new System.EventHandler(this._lbSubjects_SelectedIndexChanged);
            this._lbSubjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _tbSubject
            // 
            this._tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSubject.Location = new System.Drawing.Point(222, 53);
            this._tbSubject.Name = "_tbSubject";
            this._tbSubject.ReadOnly = true;
            this._tbSubject.Size = new System.Drawing.Size(163, 20);
            this._tbSubject.TabIndex = 1;
            this._tbSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _lSubject
            // 
            this._lSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lSubject.AutoSize = true;
            this._lSubject.Location = new System.Drawing.Point(222, 37);
            this._lSubject.Name = "_lSubject";
            this._lSubject.Size = new System.Drawing.Size(37, 13);
            this._lSubject.TabIndex = 16;
            this._lSubject.Text = "Ämne:";
            // 
            // _lFolder
            // 
            this._lFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lFolder.AutoSize = true;
            this._lFolder.Location = new System.Drawing.Point(222, 100);
            this._lFolder.Name = "_lFolder";
            this._lFolder.Size = new System.Drawing.Size(47, 13);
            this._lFolder.TabIndex = 18;
            this._lFolder.Text = "Sökväg:";
            // 
            // _tbFolder
            // 
            this._tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbFolder.Location = new System.Drawing.Point(222, 116);
            this._tbFolder.Name = "_tbFolder";
            this._tbFolder.ReadOnly = true;
            this._tbFolder.Size = new System.Drawing.Size(163, 20);
            this._tbFolder.TabIndex = 2;
            this._tbFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _bFindPath
            // 
            this._bFindPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bFindPath.Location = new System.Drawing.Point(222, 142);
            this._bFindPath.Name = "_bFindPath";
            this._bFindPath.Size = new System.Drawing.Size(163, 23);
            this._bFindPath.TabIndex = 3;
            this._bFindPath.Text = "Hitta sökväg";
            this._bFindPath.UseVisualStyleBackColor = true;
            this._bFindPath.Click += new System.EventHandler(this._bFindPath_Click);
            this._bFindPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // SubjectSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 422);
            this.Controls.Add(this._bFindPath);
            this.Controls.Add(this._lFolder);
            this.Controls.Add(this._tbFolder);
            this.Controls.Add(this._lSubject);
            this.Controls.Add(this._tbSubject);
            this.Controls.Add(this._lbSubjects);
            this.Controls.Add(this._msMain);
            this.Controls.Add(this._bAccept);
            this.MinimumSize = new System.Drawing.Size(400, 449);
            this.Name = "SubjectSettingsForm";
            this.Text = "Ämnen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectSettingsForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this._msMain.ResumeLayout(false);
            this._msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bAccept;
        private System.Windows.Forms.MenuStrip _msMain;
        private System.Windows.Forms.ToolStripMenuItem _tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem _tmsiAdd;
        private System.Windows.Forms.ToolStripSeparator _tssEdit1;
        private System.Windows.Forms.ToolStripMenuItem _tmsiEmpty;
        private System.Windows.Forms.ListBox _lbSubjects;
        private System.Windows.Forms.TextBox _tbSubject;
        private System.Windows.Forms.Label _lSubject;
        private System.Windows.Forms.Label _lFolder;
        private System.Windows.Forms.TextBox _tbFolder;
        private System.Windows.Forms.Button _bFindPath;
        private System.Windows.Forms.ToolStripMenuItem _tsmiRemove;
        private System.Windows.Forms.FolderBrowserDialog _fbdFolder;
    }
}