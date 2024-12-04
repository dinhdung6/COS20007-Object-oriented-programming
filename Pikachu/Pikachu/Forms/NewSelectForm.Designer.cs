namespace Pikachu
{
    partial class NewSelectForm
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
            
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.buttonGuide = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.PictureBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbout
            // 
           
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Image = global::Pikachu.Properties.Resources.exit1;
            this.buttonExit.Location = new System.Drawing.Point(297, 391);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(372, 152);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGuide
            // 
            this.buttonGuide.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuide.Image = global::Pikachu.Properties.Resources.guide1;
            this.buttonGuide.Location = new System.Drawing.Point(297, 216);
            this.buttonGuide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuide.Name = "buttonGuide";
            this.buttonGuide.Size = new System.Drawing.Size(372, 156);
            this.buttonGuide.TabIndex = 17;
            this.buttonGuide.TabStop = false;
            this.buttonGuide.Click += new System.EventHandler(this.buttonGuide_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = global::Pikachu.Properties.Resources.mute;
            this.pictureBox6.Location = new System.Drawing.Point(26, 30);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(83, 56);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Image = global::Pikachu.Properties.Resources.start1;
            this.buttonStart.Location = new System.Drawing.Point(297, 46);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(372, 160);
            this.buttonStart.TabIndex = 21;
            this.buttonStart.TabStop = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // NewSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Pikachu.Properties.Resources.mythical_pokemon_20th_anniversary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 688);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGuide);
            
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSelectForm";
            this.Load += new System.EventHandler(this.NewSelectForm_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox buttonAbout;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.PictureBox buttonGuide;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox buttonStart;
    }
}