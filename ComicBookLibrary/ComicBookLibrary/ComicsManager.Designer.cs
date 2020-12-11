namespace ComicBookLibrary
{
    partial class mdiComics
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewComics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewRatings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComicPersonnelLink = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageComics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManagePersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackgroundImage = global::ComicBookLibrary.Properties.Resources.bottomBar;
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip.Location = new System.Drawing.Point(0, 939);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tsmiView
            // 
            this.tsmiView.BackColor = System.Drawing.Color.Red;
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewComics,
            this.tsmiViewPersonnel,
            this.tsmiViewPublishers,
            this.tsmiViewGenres,
            this.tsmiViewRatings,
            this.tsmiViewRoles,
            this.tsmiComicPersonnelLink});
            this.tsmiView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiViewComics
            // 
            this.tsmiViewComics.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsmiViewComics.Name = "tsmiViewComics";
            this.tsmiViewComics.Size = new System.Drawing.Size(193, 22);
            this.tsmiViewComics.Text = "Comics";
            this.tsmiViewComics.Click += new System.EventHandler(this.tsmiViewComics_Click);
            // 
            // tsmiViewPersonnel
            // 
            this.tsmiViewPersonnel.BackColor = System.Drawing.Color.LightBlue;
            this.tsmiViewPersonnel.Name = "tsmiViewPersonnel";
            this.tsmiViewPersonnel.Size = new System.Drawing.Size(193, 22);
            this.tsmiViewPersonnel.Text = "Personnel";
            this.tsmiViewPersonnel.Click += new System.EventHandler(this.tsmiViewPersonnel_Click);
            // 
            // tsmiViewPublishers
            // 
            this.tsmiViewPublishers.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tsmiViewPublishers.Name = "tsmiViewPublishers";
            this.tsmiViewPublishers.Size = new System.Drawing.Size(193, 22);
            this.tsmiViewPublishers.Text = "Publishers";
            this.tsmiViewPublishers.Click += new System.EventHandler(this.tsmiViewPublishers_Click);
            // 
            // tsmiViewGenres
            // 
            this.tsmiViewGenres.BackColor = System.Drawing.Color.SteelBlue;
            this.tsmiViewGenres.Name = "tsmiViewGenres";
            this.tsmiViewGenres.Size = new System.Drawing.Size(193, 22);
            this.tsmiViewGenres.Text = "Genres";
            this.tsmiViewGenres.Click += new System.EventHandler(this.tsmiViewGenres_Click);
            // 
            // tsmiViewRatings
            // 
            this.tsmiViewRatings.BackColor = System.Drawing.Color.CadetBlue;
            this.tsmiViewRatings.Name = "tsmiViewRatings";
            this.tsmiViewRatings.Size = new System.Drawing.Size(193, 22);
            this.tsmiViewRatings.Text = "Ratings";
            this.tsmiViewRatings.Click += new System.EventHandler(this.tsmiViewRatings_Click);
            // 
            // tsmiViewRoles
            // 
            this.tsmiViewRoles.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tsmiViewRoles.Name = "tsmiViewRoles";
            this.tsmiViewRoles.Size = new System.Drawing.Size(193, 22);
            this.tsmiViewRoles.Text = "Roles";
            this.tsmiViewRoles.Click += new System.EventHandler(this.tsmiViewRoles_Click);
            // 
            // tsmiComicPersonnelLink
            // 
            this.tsmiComicPersonnelLink.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tsmiComicPersonnelLink.Name = "tsmiComicPersonnelLink";
            this.tsmiComicPersonnelLink.Size = new System.Drawing.Size(193, 22);
            this.tsmiComicPersonnelLink.Text = "Comic-Personnel-Link";
            this.tsmiComicPersonnelLink.Click += new System.EventHandler(this.tsmiComicPersonnelLink_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.BackColor = System.Drawing.Color.Red;
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.tsmiAbout});
            this.helpMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(104, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.BackColor = System.Drawing.Color.Red;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.BackColor = System.Drawing.Color.Red;
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.BackColor = System.Drawing.Color.Tomato;
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::ComicBookLibrary.Properties.Resources.topBarComic;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiView,
            this.tsmiManage,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiManage
            // 
            this.tsmiManage.BackColor = System.Drawing.Color.Red;
            this.tsmiManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageComics,
            this.tsmiManagePersonnel});
            this.tsmiManage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmiManage.Name = "tsmiManage";
            this.tsmiManage.Size = new System.Drawing.Size(62, 20);
            this.tsmiManage.Text = "Manage";
            // 
            // tsmiManageComics
            // 
            this.tsmiManageComics.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tsmiManageComics.Name = "tsmiManageComics";
            this.tsmiManageComics.Size = new System.Drawing.Size(126, 22);
            this.tsmiManageComics.Text = "Comics";
            this.tsmiManageComics.Click += new System.EventHandler(this.tsmiManageComics_Click);
            // 
            // tsmiManagePersonnel
            // 
            this.tsmiManagePersonnel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tsmiManagePersonnel.Name = "tsmiManagePersonnel";
            this.tsmiManagePersonnel.Size = new System.Drawing.Size(126, 22);
            this.tsmiManagePersonnel.Text = "Personnel";
            this.tsmiManagePersonnel.Click += new System.EventHandler(this.tsmiManagePersonnel_Click);
            // 
            // mdiComics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComicBookLibrary.Properties.Resources.comicManagerBackground;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiComics";
            this.Text = "AES Comics Manager";
            this.Load += new System.EventHandler(this.mdiComics_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewComics;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewPersonnel;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewPublishers;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewGenres;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewRatings;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewRoles;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageComics;
        private System.Windows.Forms.ToolStripMenuItem tsmiManagePersonnel;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiComicPersonnelLink;
    }
}



