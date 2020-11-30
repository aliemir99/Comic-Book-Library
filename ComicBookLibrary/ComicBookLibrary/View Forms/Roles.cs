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
    public partial class frmRoles : Form
    {
        sqlPreFilledTables sql = new sqlPreFilledTables();
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            SetDGV();
        }
        private void SetDGV()
        {
            dgvRoles.DataSource = sql.getRolesTable();
        }
    }
}
