using Pikachu.PlayViewProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu
{
    public partial class TimeOverForm : Form
    {
        public TimeOverForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Form properties
            this.Text = "Time's Up!";
            this.Size = new System.Drawing.Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Label for message
            Label messageLabel = new Label();
            messageLabel.Text = "Time over. You lose!";
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(75, 30);
            this.Controls.Add(messageLabel);

            // Play again picture box
            PictureBox playAgainPictureBox = new PictureBox();
            playAgainPictureBox.Image = Properties.Resources.play_button; // Load your play button image here
            playAgainPictureBox.Size = new System.Drawing.Size(100, 30);
            playAgainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playAgainPictureBox.Location = new System.Drawing.Point(100, 70);
            playAgainPictureBox.Click += PlayAgainPictureBox_Click;
            this.Controls.Add(playAgainPictureBox);
        }

        private void PlayAgainPictureBox_Click(object sender, EventArgs e)
        {
            // Add your code to handle the play again functionality here
            
            
            SelectPlayer selectPlayer = new SelectPlayer();
            selectPlayer.Show();
            // Close the form after handling the play again action
            this.Close();
        }
    }
}
