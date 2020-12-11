using DataAccess;
using System;
using System.Windows.Forms;

namespace ComicBookLibrary.View_Forms
{
    public partial class frmComicPersonnelLink : Form
    {
        sqlPreFilledTables sql = new sqlPreFilledTables();
        public frmComicPersonnelLink()
        {
            InitializeComponent();
        }

        private void frmComicPersonnelLink_Load(object sender, EventArgs e)
        {
            SetDGV();
        }
        public void SetDGV()
        {
            dgvComicPersonnelLink.DataSource = sql.GetComicPersonnelLinkTable();
        }
    }
}
