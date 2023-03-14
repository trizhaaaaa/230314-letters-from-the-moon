
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
            this.sign = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.letter1Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // letter1Doc
            // 
            this.letter1Doc.Image = global::jess.Properties.Resources.content_black;
            this.letter1Doc.Location = new System.Drawing.Point(133, 12);
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
            this.ff1.Location = new System.Drawing.Point(133, 413);
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
            this.btnReturn.Location = new System.Drawing.Point(532, 22);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(33, 27);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 2;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.BackColor = System.Drawing.SystemColors.ControlText;
            this.sign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.sign.Location = new System.Drawing.Point(461, 554);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(68, 15);
            this.sign.TabIndex = 9;
            this.sign.Text = "—edszx ♥";
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.BackColor = System.Drawing.SystemColors.ControlText;
            this.body.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.body.Location = new System.Drawing.Point(167, 110);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(122, 14);
            this.body.TabIndex = 8;
            this.body.Text = "body-ody-ody-ody~";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ControlText;
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.title.Location = new System.Drawing.Point(167, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(70, 22);
            this.title.TabIndex = 7;
            this.title.Text = "title :D";
            // 
            // popup_letter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 633);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.body);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ff1);
            this.Controls.Add(this.letter1Doc);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popup_letter1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup_letter1";
            this.Load += new System.EventHandler(this.popup_letter1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.letter1Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox letter1Doc;
        private System.Windows.Forms.PictureBox ff1;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.Label title;
    }
}