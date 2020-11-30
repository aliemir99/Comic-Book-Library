
using DataAccess;
using System.Windows.Forms;

namespace ComicBookLibrary
{

    public partial class frmGenres : Form
    {
        sqlPreFilledTables sql = new sqlPreFilledTables();
        public frmGenres()
        {
            InitializeComponent();
        }

        private void frmGenres_Load(object sender, System.EventArgs e)
        {
            SetDGV();
        }
        private void SetDGV()
        {
            dgvGenres.DataSource = sql.getGenresTable();
        }
    }
}
