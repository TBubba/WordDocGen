namespace WordDocGen.Forms
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this._lCredits = new System.Windows.Forms.Label();
            this._lBubba = new System.Windows.Forms.Label();
            this._lNico = new System.Windows.Forms.Label();
            this._lBubbaCred = new System.Windows.Forms.Label();
            this._lNicoCred = new System.Windows.Forms.Label();
            this._lSpecialThanks = new System.Windows.Forms.Label();
            this._rtbHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _lCredits
            // 
            this._lCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lCredits.AutoSize = true;
            this._lCredits.Location = new System.Drawing.Point(13, 258);
            this._lCredits.Name = "_lCredits";
            this._lCredits.Size = new System.Drawing.Size(76, 13);
            this._lCredits.TabIndex = 0;
            this._lCredits.Text = "Medverkande:";
            // 
            // _lBubba
            // 
            this._lBubba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lBubba.AutoSize = true;
            this._lBubba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lBubba.Location = new System.Drawing.Point(12, 271);
            this._lBubba.Name = "_lBubba";
            this._lBubba.Size = new System.Drawing.Size(111, 13);
            this._lBubba.TabIndex = 1;
            this._lBubba.Text = "Jesper Gustafsson";
            // 
            // _lNico
            // 
            this._lNico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lNico.AutoSize = true;
            this._lNico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lNico.Location = new System.Drawing.Point(172, 271);
            this._lNico.Name = "_lNico";
            this._lNico.Size = new System.Drawing.Size(116, 13);
            this._lNico.TabIndex = 2;
            this._lNico.Text = "Nicolas Gustafsson";
            // 
            // _lBubbaCred
            // 
            this._lBubbaCred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lBubbaCred.AutoSize = true;
            this._lBubbaCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lBubbaCred.Location = new System.Drawing.Point(13, 284);
            this._lBubbaCred.Name = "_lBubbaCred";
            this._lBubbaCred.Size = new System.Drawing.Size(61, 13);
            this._lBubbaCred.TabIndex = 4;
            this._lBubbaCred.Text = "- Det mesta";
            // 
            // _lNicoCred
            // 
            this._lNicoCred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lNicoCred.AutoSize = true;
            this._lNicoCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lNicoCred.Location = new System.Drawing.Point(173, 284);
            this._lNicoCred.Name = "_lNicoCred";
            this._lNicoCred.Size = new System.Drawing.Size(57, 13);
            this._lNicoCred.TabIndex = 5;
            this._lNicoCred.Text = "- Allt annat";
            // 
            // _lSpecialThanks
            // 
            this._lSpecialThanks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lSpecialThanks.AutoSize = true;
            this._lSpecialThanks.Location = new System.Drawing.Point(173, 258);
            this._lSpecialThanks.Name = "_lSpecialThanks";
            this._lSpecialThanks.Size = new System.Drawing.Size(119, 13);
            this._lSpecialThanks.TabIndex = 6;
            this._lSpecialThanks.Text = "Super-specialar-tack till:";
            // 
            // _rtbHelp
            // 
            this._rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbHelp.BackColor = System.Drawing.SystemColors.Window;
            this._rtbHelp.Location = new System.Drawing.Point(12, 12);
            this._rtbHelp.Name = "_rtbHelp";
            this._rtbHelp.ReadOnly = true;
            this._rtbHelp.Size = new System.Drawing.Size(276, 243);
            this._rtbHelp.TabIndex = 0;
            this._rtbHelp.TabStop = false;
            this._rtbHelp.Text = resources.GetString("_rtbHelp.Text");
            this._rtbHelp.WordWrap = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 312);
            this.Controls.Add(this._rtbHelp);
            this.Controls.Add(this._lSpecialThanks);
            this.Controls.Add(this._lNicoCred);
            this.Controls.Add(this._lBubbaCred);
            this.Controls.Add(this._lNico);
            this.Controls.Add(this._lBubba);
            this.Controls.Add(this._lCredits);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 83);
            this.Name = "HelpForm";
            this.Text = "Hjälp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lCredits;
        private System.Windows.Forms.Label _lBubba;
        private System.Windows.Forms.Label _lNico;
        private System.Windows.Forms.Label _lBubbaCred;
        private System.Windows.Forms.Label _lNicoCred;
        private System.Windows.Forms.Label _lSpecialThanks;
        private System.Windows.Forms.RichTextBox _rtbHelp;
    }
}