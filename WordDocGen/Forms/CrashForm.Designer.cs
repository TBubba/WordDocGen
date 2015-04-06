namespace WordDocGen.Forms
{
    partial class CrashForm
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
            this._b = new System.Windows.Forms.Button();
            this._rtbError = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _b
            // 
            this._b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._b.Location = new System.Drawing.Point(12, 238);
            this._b.Name = "_b";
            this._b.Size = new System.Drawing.Size(126, 23);
            this._b.TabIndex = 0;
            this._b.Text = "Skicka Felmeddelandet";
            this._b.UseVisualStyleBackColor = true;
            // 
            // _rtbError
            // 
            this._rtbError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbError.BackColor = System.Drawing.SystemColors.Window;
            this._rtbError.Location = new System.Drawing.Point(12, 12);
            this._rtbError.Name = "_rtbError";
            this._rtbError.ReadOnly = true;
            this._rtbError.Size = new System.Drawing.Size(268, 220);
            this._rtbError.TabIndex = 0;
            this._rtbError.TabStop = false;
            this._rtbError.Text = "";
            this._rtbError.WordWrap = false;
            // 
            // CrashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this._rtbError);
            this.Controls.Add(this._b);
            this.Name = "CrashForm";
            this.Text = "Crash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _b;
        private System.Windows.Forms.RichTextBox _rtbError;
    }
}