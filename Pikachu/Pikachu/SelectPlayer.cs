using System;
using System.Windows.Forms;
using Pikachu.PlayViewProcess;
using Pikachu;

namespace Pikachu
{
    public partial class SelectPlayer : Form
    {
        Sounds sound = new Sounds(AppDomain.CurrentDomain.BaseDirectory + "//Sounds and img Sounds//Content//102-palette town theme.mp3");


        public SelectPlayer()
        {
            InitializeComponent();
        }

        private void SelectPlayer_Load(object sender, EventArgs e)
        {
            sound.Resume();
        }

        

        private void button1player_Click(object sender, EventArgs e)
        {
            Playformwith_1player one_Player = new Playformwith_1player();
            one_Player.Show();
            sound.Stop();
        }
    }
}
