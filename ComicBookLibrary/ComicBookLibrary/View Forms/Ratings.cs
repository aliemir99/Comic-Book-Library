using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookLibrary
{
    public partial class frmRatings : Form
    {
        sqlPreFilledTables sql = new sqlPreFilledTables();
        public frmRatings()
        {
            InitializeComponent();
        }

        private void frmRatings_Load(object sender, EventArgs e)
        {
            SetDGV();
        }
        private void SetDGV()
        {
            dgvRatings.DataSource = sql.getRatingsTable();
        }
    }
}
