
namespace jess
{
    partial class popup_letter2
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
            this.letter2Doc = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.ff1 = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.letter2Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).BeginInit();
            this.SuspendLayout();
            // 
            // letter2Doc
            // 
            this.letter2Doc.Image = global::jess.Properties.Resources.content_black;
            this.letter2Doc.Location = new System.Drawing.Point(133, 12);
            this.letter2Doc.Name = "letter2Doc";
            this.letter2Doc.Size = new System.Drawing.Size(444, 609);
            this.letter2Doc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.letter2Doc.TabIndex = 1;
            this.letter2Doc.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = global::jess.Properties.Resources.red;
            this.btnReturn.Location = new System.Drawing.Point(532, 22);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(33, 27);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 3;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ff1
            // 
            this.ff1.BackColor = System.Drawing.SystemColors.ControlText;
            this.ff1.Image = global::jess.Properties.Resources.ff17;
            this.ff1.Location = new System.Drawing.Point(138, 450);
            this.ff1.Name = "ff1";
            this.ff1.Size = new System.Drawing.Size(149, 166);
            this.ff1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ff1.TabIndex = 4;
            this.ff1.TabStop = false;
            // 
            // popup_letter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 633);
            this.Controls.Add(this.ff1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.letter2Doc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup_letter2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup_letter2";
            ((System.ComponentModel.ISupportInitialize)(this.letter2Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox letter2Doc;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.PictureBox ff1;
        private System.Windows.Forms.ToolTip tt;
    }
}