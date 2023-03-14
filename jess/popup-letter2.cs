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
    public partial class popup_letter2 : Form
    {
        public popup_letter2()
        {
            InitializeComponent();
        }
        private void popup_letter2_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.SaddleBrown;
            this.TransparencyKey = Color.SaddleBrown;

            var returnLoc = btnReturn.PointToScreen(Point.Empty);
            btnReturn.Parent = letter2Doc;
            btnReturn.Location = letter2Doc.PointToClient(returnLoc);
            btnReturn.BackColor = Color.Transparent;
            tt.SetToolTip(this.btnReturn, "◄ to the moon");

            var ff1Loc = ff1.PointToScreen(Point.Empty);
            ff1.Parent = letter2Doc;
            ff1.Location = letter2Doc.PointToClient(ff1Loc);
            ff1.BackColor = Color.Transparent;

            var titleLoc = title.PointToScreen(Point.Empty);
            title.Parent = letter2Doc;
            title.Location = letter2Doc.PointToClient(titleLoc);
            title.BackColor = Color.Transparent;

            var bodyLoc = body.PointToScreen(Point.Empty);
            body.Parent = letter2Doc;
            body.Location = letter2Doc.PointToClient(bodyLoc);
            body.BackColor = Color.Transparent;

            var signLoc = sign.PointToScreen(Point.Empty);
            sign.Parent = letter2Doc;
            sign.Location = letter2Doc.PointToClient(signLoc);
            sign.BackColor = Color.Transparent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

            moonMain mm = new moonMain();
            mm.Show();
        }
    }
}
