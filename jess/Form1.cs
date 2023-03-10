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
    }
}
