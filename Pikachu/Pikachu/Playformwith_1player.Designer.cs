namespace Pikachu
{
    partial class Playformwith_1player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelHelp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelContainIcon = new System.Windows.Forms.Panel();
            this.buttonPlayAgain = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.BackColor = System.Drawing.Color.Black;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.ForeColor = System.Drawing.Color.Lime;
            this.labelHelp.Location = new System.Drawing.Point(62, 363);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(0, 37);
            this.labelHelp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 34);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(224, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 47);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time";
            // 
            // progressBarTime
            // 
            this.progressBarTime.BackColor = System.Drawing.Color.DodgerBlue;
            this.progressBarTime.ForeColor = System.Drawing.Color.Gold;
            this.progressBarTime.Location = new System.Drawing.Point(347, 18);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarTime.Maximum = 3000;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(720, 40);
            this.progressBarTime.Step = 1;
            this.progressBarTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTime.TabIndex = 11;
            this.progressBarTime.Value = 1;
            this.progressBarTime.Click += new System.EventHandler(this.progressBarTime_Click);
            this.progressBarTime.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.progressBarTime_ChangeUICues);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // panelContainIcon
            // 
            this.panelContainIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelContainIcon.Location = new System.Drawing.Point(252, 79);
            this.panelContainIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainIcon.Name = "panelContainIcon";
            this.panelContainIcon.Size = new System.Drawing.Size(994, 595);
            this.panelContainIcon.TabIndex = 0;
            this.panelContainIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainIcon_Paint);
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayAgain.Image = global::Pikachu.Properties.Resources.play_button;
            this.buttonPlayAgain.Location = new System.Drawing.Point(13, 482);
            this.buttonPlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(217, 93);
            this.buttonPlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPlayAgain.TabIndex = 12;
            this.buttonPlayAgain.TabStop = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Image = global::Pikachu.Properties.Resources.exit2;
            this.buttonExit.Location = new System.Drawing.Point(15, 585);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(209, 89);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonExit.TabIndex = 13;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pikachu.Properties.Resources.mute;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(36, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 63);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Playformwith_1player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::Pikachu.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 715);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.panelContainIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Playformwith_1player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.Playformwith_1player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainIcon;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarTime;    
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox buttonPlayAgain;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}