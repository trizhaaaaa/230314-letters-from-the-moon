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
    public partial class popup_letter1 : Form
    {
        public popup_letter1()
        {
            InitializeComponent();

            this.BackColor = Color.SaddleBrown;
            this.TransparencyKey = Color.SaddleBrown;

            var returnLoc = btnReturn.PointToScreen(Point.Empty);
            btnReturn.Parent = letter1Doc;
            btnReturn.Location = letter1Doc.PointToClient(returnLoc);
            btnReturn.BackColor = Color.Transparent;
            tt.SetToolTip(this.btnReturn, "◄ to the moon");

            var ff1Loc = ff1.PointToScreen(Point.Empty);
            ff1.Parent = letter1Doc;
            ff1.Location = letter1Doc.PointToClient(ff1Loc);
            ff1.BackColor = Color.Transparent;
            

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

            moonMain mm = new moonMain();
            mm.Show();
        }
    }
}
