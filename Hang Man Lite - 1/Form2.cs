using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_Man_Lite___1
{
    public partial class frmSelectPlayerCount : Form
    {
        public static bool onePlayer;
        public static bool twoPlayer;
        public frmSelectPlayerCount()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPlayerOne_Click(object sender, EventArgs e)
        {
            this.Close();
            onePlayer = true;
        }

        private void btnPlayerTwo_Click(object sender, EventArgs e)
        {
            this.Close();
            twoPlayer = true;
        }
    }
}
