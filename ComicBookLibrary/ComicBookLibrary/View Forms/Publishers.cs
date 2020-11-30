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
    public partial class frmPublishers : Form
    {
        sqlPreFilledTables sql = new sqlPreFilledTables();
        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            SetDGV();
            
        }
        private void SetDGV()
        {
            dgvPublishers.DataSource = sql.getPublishersTable();
            dgvPublishers.Columns["PublisherDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
