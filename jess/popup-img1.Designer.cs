
namespace jess
{
    partial class popup_img1
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
            this.bg = new System.Windows.Forms.PictureBox();
            this.ff1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.Image = global::jess.Properties.Resources.content_white;
            this.bg.Location = new System.Drawing.Point(12, 343);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(390, 234);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // ff1
            // 
            this.ff1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ff1.Image = global::jess.Properties.Resources.ff6;
            this.ff1.Location = new System.Drawing.Point(295, 477);
            this.ff1.Name = "ff1";
            this.ff1.Size = new System.Drawing.Size(107, 100);
            this.ff1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ff1.TabIndex = 1;
            this.ff1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = global::jess.Properties.Resources.red;
            this.btnReturn.Location = new System.Drawing.Point(408, 22);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(33, 27);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 4;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // popup_img1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 596);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ff1);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup_img1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup_img1";
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox ff1;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.ToolTip tt;
    }
}