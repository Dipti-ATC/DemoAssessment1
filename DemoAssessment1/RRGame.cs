using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAssessment1
{
    public partial class RRGame : Form
    {
        RRClass RRRun = new RRClass();

        public RRGame()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Loading One Bullet");
            RRRun.LoadGun();
           
        }

        private void SpinBtn_Click(object sender, EventArgs e)
        {
            RRRun.SpinGun();
        }
        private void ShootBtn_Click(object sender, EventArgs e)
        {
            RRRun.ShootGun();
        }

        private void ShootAwayBtn_Click(object sender, EventArgs e)
        {
            RRRun.ShootAwayGun();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            RRRun.DisplayScore();
        }
    }
}
