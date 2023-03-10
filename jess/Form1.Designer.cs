
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
            this.moonExit = new System.Windows.Forms.PictureBox();
            this.moonInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.moonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // moonExit
            // 
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
            this.moonInfo.Image = global::jess.Properties.Resources.star;
            this.moonInfo.Location = new System.Drawing.Point(430, 113);
            this.moonInfo.Name = "moonInfo";
            this.moonInfo.Size = new System.Drawing.Size(50, 50);
            this.moonInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moonInfo.TabIndex = 1;
            this.moonInfo.TabStop = false;
            this.moonInfo.Click += new System.EventHandler(this.moonInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jess.Properties.Resources.moon;
            this.pictureBox1.Location = new System.Drawing.Point(45, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // moonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.moonExit);
            this.Controls.Add(this.moonInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "moonMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.moonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox moonInfo;
        private System.Windows.Forms.PictureBox moonExit;
        private System.Windows.Forms.ToolTip tt;
    }
}

