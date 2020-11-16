using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAssessment1
{
    /// <summary>
    /// Assessment does not clarify how the score 
    /// </summary>
    public class RRClass
    {
        int Bullet;
        int Chances = 2;
        int NumWin = 0;
        int NumLost = 0;
        public void LoadGun()
        {
            Bullet = 0;
           // Console.WriteLine(Bullet);
        }
        public void SpinGun()
        {
            Random BulletPlace = new Random();
            Bullet = BulletPlace.Next(0, 6);
            //Console.WriteLine(Bullet);
        }
        public void ShootGun()
        {
            if(Bullet==5)
            {
                MessageBox.Show("You lost:(");
                NumLost++;
            }
            else
            {
                MessageBox.Show("You SURVIVED :)");
                Bullet++;
                NumWin++;
            }
        }
        public void ShootAwayGun()
        {
            if (Chances > 0)
            {

                if (Bullet == 5)
                {
                    NumWin++;
                    Chances--;
                    MessageBox.Show(string.Format("You Survived !!! only {0} chances remains ",Chances));
                    //MessageBox.Show(Chances.ToString()+" Chance left");
                }
                else
                {
                   Chances--;
                    MessageBox.Show(Chances.ToString() + " Chance left");

                }
            }
            else
            {
                MessageBox.Show("No chance to shoot away");

            }
        }
        public void DisplayScore()
        {
            MessageBox.Show(string.Format("You Won {0} times and lost {1}", NumWin,NumLost));
        }

    }
}
