
namespace jess
{
    partial class moonMain
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
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.photo1 = new System.Windows.Forms.PictureBox();
            this.letter1 = new System.Windows.Forms.PictureBox();
            this.moonExit = new System.Windows.Forms.PictureBox();
            this.moonInfo = new System.Windows.Forms.PictureBox();
            this.moonface = new System.Windows.Forms.PictureBox();
            this.letter2 = new System.Windows.Forms.PictureBox();
            this.photo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo2)).BeginInit();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 5000;
            this.tt.InitialDelay = 500;
            this.tt.ReshowDelay = 100;
            // 
            // photo1
            // 
            this.photo1.Location = new System.Drawing.Point(329, 176);
            this.photo1.Name = "photo1";
            this.photo1.Size = new System.Drawing.Size(43, 19);
            this.photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo1.TabIndex = 3;
            this.photo1.TabStop = false;
            this.photo1.Click += new System.EventHandler(this.photo1_Click);
            this.photo1.MouseEnter += new System.EventHandler(this.photo1_MouseEnter);
            // 
            // letter1
            // 
            this.letter1.Location = new System.Drawing.Point(179, 372);
            this.letter1.Name = "letter1";
            this.letter1.Size = new System.Drawing.Size(32, 25);
            this.letter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.letter1.TabIndex = 3;
            this.letter1.TabStop = false;
            this.letter1.Click += new System.EventHandler(this.letter1_Click);
            this.letter1.MouseEnter += new System.EventHandler(this.letter1_MouseEnter);
            // 
            // moonExit
            // 
            this.moonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moonExit.Image = global::jess.Properties.Resources.x;
            this.moonExit.Location = new System.Drawing.Point(495, 113);
            this.moonExit.Name = "moonExit";
            this.moonExit.Size = new System.Drawing.Size(50, 50);
            this.moonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moonExit.TabIndex = 2;
            this.moonExit.TabStop = false;
            this.moonExit.Click += new System.EventHandler(this.moonExit_Click);
            // 
            // moonInfo
            // 
            this.moonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moonInfo.Image = global::jess.Properties.Resources.star;
            this.moonInfo.Location = new System.Drawing.Point(430, 113);
            this.moonInfo.Name = "moonInfo";
            this.moonInfo.Size = new System.Drawing.Size(50, 50);
            this.moonInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moonInfo.TabIndex = 1;
            this.moonInfo.TabStop = false;
            this.moonInfo.Click += new System.EventHandler(this.moonInfo_Click);
            // 
            // moonface
            // 
            this.moonface.Image = global::jess.Properties.Resources.moon;
            this.moonface.Location = new System.Drawing.Point(45, 169);
            this.moonface.Name = "moonface";
            this.moonface.Size = new System.Drawing.Size(500, 500);
            this.moonface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moonface.TabIndex = 0;
            this.moonface.TabStop = false;
            // 
            // letter2
            // 
            this.letter2.Location = new System.Drawing.Point(380, 372);
            this.letter2.Name = "letter2";
            this.letter2.Size = new System.Drawing.Size(32, 25);
            this.letter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.letter2.TabIndex = 3;
            this.letter2.TabStop = false;
            this.letter2.Click += new System.EventHandler(this.letter2_Click);
            this.letter2.MouseEnter += new System.EventHandler(this.letter2_MouseEnter);
            // 
            // photo2
            // 
            this.photo2.Location = new System.Drawing.Point(347, 594);
            this.photo2.Name = "photo2";
            this.photo2.Size = new System.Drawing.Size(24, 21);
            this.photo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo2.TabIndex = 4;
            this.photo2.TabStop = false;
            this.photo2.Click += new System.EventHandler(this.photo2_Click);
            this.photo2.MouseEnter += new System.EventHandler(this.photo2_MouseEnter);
            // 
            // moonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.photo2);
            this.Controls.Add(this.photo1);
            this.Controls.Add(this.letter2);
            this.Controls.Add(this.letter1);
            this.Controls.Add(this.moonExit);
            this.Controls.Add(this.moonInfo);
            this.Controls.Add(this.moonface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "moonMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.photo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox moonface;
        private System.Windows.Forms.PictureBox moonInfo;
        private System.Windows.Forms.PictureBox moonExit;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.PictureBox letter1;
        private System.Windows.Forms.PictureBox photo1;
        private System.Windows.Forms.PictureBox letter2;
        private System.Windows.Forms.PictureBox photo2;
    }
}

