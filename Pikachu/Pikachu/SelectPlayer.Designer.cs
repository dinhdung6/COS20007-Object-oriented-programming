namespace Pikachu
{
    partial class SelectPlayer
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
            this.button1player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button1player)).BeginInit();
            this.SuspendLayout();
            // 
            // button1player
            // 
            this.button1player.BackColor = System.Drawing.Color.Transparent;
            this.button1player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1player.Image = global::Pikachu.Properties.Resources.start2;
            this.button1player.Location = new System.Drawing.Point(169, 185);
            this.button1player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1player.Name = "button1player";
            this.button1player.Size = new System.Drawing.Size(321, 127);
            this.button1player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button1player.TabIndex = 15;
            this.button1player.TabStop = false;
            this.button1player.Click += new System.EventHandler(this.button1player_Click);
            // 
            // SelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Pikachu.Properties.Resources.anh_pikachu_de_thuong_9;
            this.ClientSize = new System.Drawing.Size(658, 572);
            this.Controls.Add(this.button1player);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectPlayer";
            this.Text = "Startplay";
            this.Load += new System.EventHandler(this.SelectPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button1player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox button1player;
    }
}