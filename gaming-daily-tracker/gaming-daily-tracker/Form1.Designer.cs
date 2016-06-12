namespace gaming_daily_tracker
{
    partial class frmGamingDailyTracker
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
            this.tmrUpdater = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picArtGW2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtGW2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUpdater
            // 
            this.tmrUpdater.Interval = 1000;
            this.tmrUpdater.Tick += new System.EventHandler(this.tmrUpdater_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(28, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 24);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = " Add a game...";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::gaming_daily_tracker.Properties.Resources.GOGList;
            this.pictureBox8.Location = new System.Drawing.Point(310, 223);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(230, 108);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::gaming_daily_tracker.Properties.Resources.imgBattlePassTI6;
            this.pictureBox4.Location = new System.Drawing.Point(74, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(230, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gaming_daily_tracker.Properties.Resources.imgWWDC;
            this.pictureBox2.Location = new System.Drawing.Point(310, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picArtGW2
            // 
            this.picArtGW2.Image = global::gaming_daily_tracker.Properties.Resources.imgHeartOfThorns;
            this.picArtGW2.Location = new System.Drawing.Point(74, 109);
            this.picArtGW2.Name = "picArtGW2";
            this.picArtGW2.Size = new System.Drawing.Size(230, 108);
            this.picArtGW2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtGW2.TabIndex = 2;
            this.picArtGW2.TabStop = false;
            // 
            // frmGamingDailyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 630);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picArtGW2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox1);
            this.Name = "frmGamingDailyTracker";
            this.Text = "Gaming Daily Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtGW2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrUpdater;
        private System.Windows.Forms.PictureBox picArtGW2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

