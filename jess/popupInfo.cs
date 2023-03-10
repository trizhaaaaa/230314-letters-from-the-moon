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
    public partial class popupInfo : Form
    {
        public popupInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

            moonMain mm = new moonMain();
            mm.Show();
        }

        private void popupInfo_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.SaddleBrown;
            this.TransparencyKey = Color.SaddleBrown;

            var it1Loc = infoText1.PointToScreen(Point.Empty); 
            infoText1.Parent = bg1;
            infoText1.Location = bg1.PointToClient(it1Loc);
            infoText1.BackColor = Color.Transparent;

            var it2Loc = infoText2.PointToScreen(Point.Empty);
            infoText2.Parent = bg1;
            infoText2.Location = bg1.PointToClient(it2Loc);
            infoText2.BackColor = Color.Transparent;

            var it3Loc = infoText3.PointToScreen(Point.Empty);
            infoText3.Parent = bg1;
            infoText3.Location = bg1.PointToClient(it3Loc);
            infoText3.BackColor = Color.Transparent;

            var it4Loc = infoText4.PointToScreen(Point.Empty);
            infoText4.Parent = bg1;
            infoText4.Location = bg1.PointToClient(it4Loc);
            infoText4.BackColor = Color.Transparent;

            var it5Loc = infoText5.PointToScreen(Point.Empty);
            infoText5.Parent = bg2;
            infoText5.Location = bg2.PointToClient(it5Loc);
            infoText5.BackColor = Color.Transparent;

            var it6Loc = infoText6.PointToScreen(Point.Empty);
            infoText6.Parent = bg2;
            infoText6.Location = bg2.PointToClient(it6Loc);
            infoText6.BackColor = Color.Transparent;


            tt.SetToolTip(this.back, "◄ to the moon");

        }
    }
}
