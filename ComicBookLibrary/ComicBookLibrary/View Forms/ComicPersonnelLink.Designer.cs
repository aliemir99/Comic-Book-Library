namespace ComicBookLibrary.View_Forms
{
    partial class frmComicPersonnelLink
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
            this.dgvComicPersonnelLink = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComicPersonnelLink)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComicPersonnelLink
            // 
            this.dgvComicPersonnelLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComicPersonnelLink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComicPersonnelLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComicPersonnelLink.Location = new System.Drawing.Point(12, 12);
            this.dgvComicPersonnelLink.Name = "dgvComicPersonnelLink";
            this.dgvComicPersonnelLink.Size = new System.Drawing.Size(555, 313);
            this.dgvComicPersonnelLink.TabIndex = 0;
            // 
            // frmComicPersonnelLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.dgvComicPersonnelLink);
            this.Name = "frmComicPersonnelLink";
            this.Text = "ComicPersonnelLink";
            this.Load += new System.EventHandler(this.frmComicPersonnelLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComicPersonnelLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComicPersonnelLink;
    }
}