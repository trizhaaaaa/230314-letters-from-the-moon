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
    public partial class moonMain : Form
    {
        public moonMain()
        {
            InitializeComponent();

            this.BackColor = Color.SaddleBrown;
            this.TransparencyKey = Color.SaddleBrown;

            tt.SetToolTip(this.moonInfo, "Sagot sa \"Anong gagawin ko dito, beh???\"");
            tt.SetToolTip(this.moonExit, "Babyeeee! ♥");

            var let1Loc = letter1.PointToScreen(Point.Empty);
            letter1.Parent = moonface;
            letter1.Location = moonface.PointToClient(let1Loc);
            letter1.BackColor = Color.Transparent;
            tt.SetToolTip(this.letter1, "from eds ♥");

            var let2Loc = letter2.PointToScreen(Point.Empty);
            letter2.Parent = moonface;
            letter2.Location = moonface.PointToClient(let2Loc);
            letter2.BackColor = Color.Transparent;
            tt.SetToolTip(this.letter2, "from trizha ♥");

            var img1Loc = photo1.PointToScreen(Point.Empty);
            photo1.Parent = moonface;
            photo1.Location = moonface.PointToClient(img1Loc);
            photo1.BackColor = Color.Transparent;
            tt.SetToolTip(this.photo1, "Hello!!!!!!");

        }

        private void moonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void moonInfo_Click(object sender, EventArgs e)
        {
            popupInfo popup = new popupInfo();
            popup.Show();
            this.Hide();
        }
        //-----------------------------------------------------
        //
        //letter 1
        //
        private void letter1_Click(object sender, EventArgs e)
        {
            popup_letter1 popup = new popup_letter1();
            popup.Show();
            this.Hide();
        }
        //
        private void letter1_MouseEnter(object sender, EventArgs e)
        {
            Cursor letCur = new Cursor(Properties.Resources.letter_hearts_2_ico.Handle);
            letter1.Cursor = letCur;
        }
        //
        //letter 2
        //
        private void letter2_Click(object sender, EventArgs e)
        {
            popup_letter2 popup = new popup_letter2();
            popup.Show();
            this.Hide();
        }
        //
        private void letter2_MouseEnter(object sender, EventArgs e)
        {
            Cursor letCur = new Cursor(Properties.Resources.letter_hearts_2_ico.Handle);
            letter2.Cursor = letCur;
        }
        //
        //
        //
        // photo
        //
        private void photo1_Click(object sender, EventArgs e)
        {
            //show image
        }
        //
        private void photo1_MouseEnter(object sender, EventArgs e)
        {
            Cursor picCur = new Cursor(Properties.Resources.camera_2_ico.Handle);
            photo1.Cursor = picCur;
        }
    }
}
