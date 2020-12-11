using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComicBookFactories;
using ComicBookLibrary.About_Form;
using ComicBookLibrary.Manage_Forms;
using ComicBookLibrary.View_Forms;
using VideoGameMaintenance;

namespace ComicBookLibrary

{
    public partial class mdiComics : Form
    {
        private int childFormNumber = 0;

        public mdiComics()
        {
            InitializeComponent();
        }

        private void mdiComics_Load(object sender, EventArgs e)
        {
            //setup comics list, personnel list etc...
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        /*
            VIEW TOOL STRIP MENU ITEM CLICKS
         */
        //DISPLAYS COMICS TABLE ON A NEW WINDOW
        private void tsmiViewComics_Click(object sender, EventArgs e)
        {
            Form ComicsForm = new frmComics();
            ComicsForm.MdiParent = this;
            ComicsForm.BringToFront();
            ComicsForm.Show();
        }

        //DISPLAYS PERSONNEL TABLE ON A NEW WINDOW
        private void tsmiViewPersonnel_Click(object sender, EventArgs e)
        {
            Form personnelForm = new frmPersonnels();
            personnelForm.MdiParent = this;
            personnelForm.BringToFront();
            personnelForm.Show();
        }
        //DISPLAYS PUBLISHER TABLE ON A NEW WINDOW
        private void tsmiViewPublishers_Click(object sender, EventArgs e)
        {
            Form publisherForm = new frmPublishers();
            publisherForm.MdiParent = this;
            publisherForm.BringToFront();
            publisherForm.Show();
        }
        //DISPLAYS GENRE TABLE ON A NEW WINDOW
        private void tsmiViewGenres_Click(object sender, EventArgs e)
        {
            Form genreForm = new frmGenres();
            genreForm.MdiParent = this;
            genreForm.BringToFront();
            genreForm.Show();
        }
        //DISPLAYS RATING TABLE ON A NEW WINDOW
        private void tsmiViewRatings_Click(object sender, EventArgs e)
        {
            Form ratingForm = new frmRatings();
            ratingForm.MdiParent = this;
            ratingForm.BringToFront();
            ratingForm.Show();
        }
        //DISPLAYS ROLE TABLE ON A NEW WINDOW
        private void tsmiViewRoles_Click(object sender, EventArgs e)
        {
            Form roleForm = new frmRoles();
            roleForm.MdiParent = this;
            roleForm.BringToFront();
            roleForm.Show();
        }

        /*
         MANAGE TOOL STRIP MENU ITEM CLICKS
        */
        private void tsmiManageComics_Click(object sender, EventArgs e)
        {
            Form manageComicsForm = new frmManageComicBooks();
            manageComicsForm.MdiParent = this;
            manageComicsForm.BringToFront();
            manageComicsForm.Show();
        }
        
        private void tsmiManagePersonnel_Click(object sender, EventArgs e)
        {
            Form managePersonnelForm = new frmManagePersonnels();
            managePersonnelForm.MdiParent = this;
            managePersonnelForm.BringToFront();
            managePersonnelForm.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.MdiParent = this;
            about.BringToFront();
            about.Show();
        }

        private void tsmiComicPersonnelLink_Click(object sender, EventArgs e)
        {
            Form linkedTableForm = new frmComicPersonnelLink();
            linkedTableForm.MdiParent = this;
            linkedTableForm.BringToFront();
            linkedTableForm.Show();
        }
    }
}
