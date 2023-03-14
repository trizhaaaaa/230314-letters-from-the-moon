
namespace jess
{
    partial class popup_letter1
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
            this.components = new System.ComponentModel.Container();
            this.letter1Doc = new System.Windows.Forms.PictureBox();
            this.ff1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.letter1Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // letter1Doc
            // 
            this.letter1Doc.Image = global::jess.Properties.Resources.content_black;
            this.letter1Doc.Location = new System.Drawing.Point(51, 12);
            this.letter1Doc.Name = "letter1Doc";
            this.letter1Doc.Size = new System.Drawing.Size(444, 609);
            this.letter1Doc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.letter1Doc.TabIndex = 0;
            this.letter1Doc.TabStop = false;
            // 
            // ff1
            // 
            this.ff1.BackColor = System.Drawing.SystemColors.ControlText;
            this.ff1.Image = global::jess.Properties.Resources.ff19;
            this.ff1.Location = new System.Drawing.Point(51, 413);
            this.ff1.Name = "ff1";
            this.ff1.Size = new System.Drawing.Size(149, 208);
            this.ff1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ff1.TabIndex = 1;
            this.ff1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = global::jess.Properties.Resources.red;
            this.btnReturn.Location = new System.Drawing.Point(451, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(33, 27);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 2;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // popup_letter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(727, 671);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ff1);
            this.Controls.Add(this.letter1Doc);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup_letter1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup_letter1";
            ((System.ComponentModel.ISupportInitialize)(this.letter1Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox letter1Doc;
        private System.Windows.Forms.PictureBox ff1;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.ToolTip tt;
    }
}