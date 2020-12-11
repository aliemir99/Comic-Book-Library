namespace VideoGameMaintenance
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.picLoadSplash = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // picLoadSplash
            // 
            this.picLoadSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoadSplash.BackgroundImage")));
            this.picLoadSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoadSplash.InitialImage = null;
            this.picLoadSplash.Location = new System.Drawing.Point(-1, -2);
            this.picLoadSplash.Name = "picLoadSplash";
            this.picLoadSplash.Size = new System.Drawing.Size(818, 257);
            this.picLoadSplash.TabIndex = 0;
            this.picLoadSplash.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(-13, 207);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(830, 23);
            this.pbLoading.TabIndex = 1;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 254);
            this.ControlBox = false;
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.picLoadSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Game Library";
            this.Load += new System.EventHandler(this.LoadSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoadSplash;
        private System.Windows.Forms.ProgressBar pbLoading;
    }
}