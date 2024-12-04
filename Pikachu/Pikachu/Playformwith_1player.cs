using System;
using System.Windows.Forms;
using Pikachu.PlayViewProcess;

using Pikachu;

namespace Pikachu
{
    public partial class Playformwith_1player : Form
    {
        private int remainingIcons;
        Sounds sound = new Sounds(AppDomain.CurrentDomain.BaseDirectory + "//Sounds and img Sounds//Content//102-palette town theme.mp3");
        int i_sounds = 1;
        public Playformwith_1player()
        {
            InitializeComponent();
            // Chạy timer, có tác dụng ở progressBar
            timer.Start();
            InitialProcessEvent InitialProcessPlay = new InitialProcessEvent();
            DrawPanelContainIcon drawPanelContainIcon = new DrawPanelContainIcon();
            InitialProcessPlay.ProcessEvent(drawPanelContainIcon, panelContainIcon);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (remainingIcons == 0)
            {
                // Show the new form
                
            }
        }
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playformwith_1player newPlayForm = new Playformwith_1player();
            newPlayForm.StartPosition = FormStartPosition.CenterScreen;
            sound.Stop();
            newPlayForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i_sounds++;
            Playformwith_1player_Load(sender, e);
        }

        private void Playformwith_1player_Load(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
            if (i_sounds % 2 == 0)
            {
                sound.Pause();
            }
            else
            {
                sound.Resume();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            progressBarTime.PerformStep();
            if (progressBarTime.Value == progressBarTime.Maximum)
            {
                TimeOverForm timeOver = new TimeOverForm();
                timeOver.Show();
                sound.Stop();
                this.Close();
                
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            sound.Stop();
            this.Close();
        }

        private void progressBarTime_Click(object sender, EventArgs e)
        {

        }

        private void panelContainIcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBarTime_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
        public void UpdateRemainingIconsCount()
        {
            remainingIcons--;
        }
    }
}

