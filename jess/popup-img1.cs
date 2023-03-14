using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jess
{
    public partial class popup_img1 : Form
    {
        public popup_img1()
        {
            InitializeComponent();

            this.BackColor = Color.SaddleBrown;
            this.TransparencyKey = Color.SaddleBrown;

            btnReturn.BackColor = Color.Transparent;
            tt.SetToolTip(this.btnReturn, "◄ to the moon");

            var ff1Loc = ff1.PointToScreen(Point.Empty);
            ff1.Parent = bg;
            ff1.Location = bg.PointToClient(ff1Loc);
            ff1.BackColor = Color.Transparent;
            tt.SetToolTip(this.ff1, "Hello!!!!!!");

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

            moonMain mm = new moonMain();
            mm.Show();
        }
    }
}
