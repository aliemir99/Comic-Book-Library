namespace ComicBookLibrary.About_Form
{
    partial class frmAbout
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
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRights = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRights)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTitle
            // 
            this.pbTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTitle.Image = global::ComicBookLibrary.Properties.Resources.title;
            this.pbTitle.InitialImage = null;
            this.pbTitle.Location = new System.Drawing.Point(43, 12);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(404, 50);
            this.pbTitle.TabIndex = 0;
            this.pbTitle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComicBookLibrary.Properties.Resources.author;
            this.pictureBox1.Location = new System.Drawing.Point(145, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbRights
            // 
            this.pbRights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRights.Image = global::ComicBookLibrary.Properties.Resources.rights;
            this.pbRights.Location = new System.Drawing.Point(182, 315);
            this.pbRights.Name = "pbRights";
            this.pbRights.Size = new System.Drawing.Size(136, 19);
            this.pbRights.TabIndex = 2;
            this.pbRights.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVersion.Location = new System.Drawing.Point(397, 350);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(62, 15);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version 1.0";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(76, 108);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(337, 201);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComicBookLibrary.Properties.Resources.backgroundAbout;
            this.ClientSize = new System.Drawing.Size(469, 381);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pbRights);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbTitle);
            this.Name = "frmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRights;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}