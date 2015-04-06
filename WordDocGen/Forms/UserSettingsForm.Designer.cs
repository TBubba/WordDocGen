namespace WordDocGen.Forms
{
    partial class UserSettingsForm
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
            this._lGrade = new System.Windows.Forms.Label();
            this._lFullName = new System.Windows.Forms.Label();
            this._tbGrade = new System.Windows.Forms.TextBox();
            this._tbFullName = new System.Windows.Forms.TextBox();
            this._bApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lGrade
            // 
            this._lGrade.AutoSize = true;
            this._lGrade.Location = new System.Drawing.Point(11, 46);
            this._lGrade.Name = "_lGrade";
            this._lGrade.Size = new System.Drawing.Size(35, 13);
            this._lGrade.TabIndex = 14;
            this._lGrade.Text = "Klass:";
            this._lGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lFullName
            // 
            this._lFullName.AutoSize = true;
            this._lFullName.Location = new System.Drawing.Point(11, 7);
            this._lFullName.Name = "_lFullName";
            this._lFullName.Size = new System.Drawing.Size(99, 13);
            this._lFullName.TabIndex = 13;
            this._lFullName.Text = "För- och efternamn:";
            this._lFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tbGrade
            // 
            this._tbGrade.Location = new System.Drawing.Point(12, 62);
            this._tbGrade.Name = "_tbGrade";
            this._tbGrade.Size = new System.Drawing.Size(191, 20);
            this._tbGrade.TabIndex = 1;
            this._tbGrade.Text = "SUN12";
            this._tbGrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _tbFullName
            // 
            this._tbFullName.Location = new System.Drawing.Point(12, 23);
            this._tbFullName.Name = "_tbFullName";
            this._tbFullName.Size = new System.Drawing.Size(191, 20);
            this._tbFullName.TabIndex = 0;
            this._tbFullName.Text = "För- och efternamn";
            this._tbFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // _bApply
            // 
            this._bApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._bApply.Location = new System.Drawing.Point(116, 97);
            this._bApply.Name = "_bApply";
            this._bApply.Size = new System.Drawing.Size(87, 23);
            this._bApply.TabIndex = 2;
            this._bApply.Text = "Verkställ";
            this._bApply.UseVisualStyleBackColor = true;
            this._bApply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 130);
            this.Controls.Add(this._bApply);
            this.Controls.Add(this._lGrade);
            this.Controls.Add(this._lFullName);
            this.Controls.Add(this._tbGrade);
            this.Controls.Add(this._tbFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserSettingsForm";
            this.ShowIcon = false;
            this.Text = "Användarinställningar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettingsForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lGrade;
        private System.Windows.Forms.Label _lFullName;
        private System.Windows.Forms.TextBox _tbGrade;
        private System.Windows.Forms.Button _bApply;
        private System.Windows.Forms.TextBox _tbFullName;
    }
}