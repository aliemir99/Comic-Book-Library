using ComicBookFactories;
using System.Windows.Forms;

namespace ComicBookLibrary
{
    public partial class frmComics : Form
    {
        private IComicBookRepo comicsRepo;
        public frmComics()
        {
            InitializeComponent();
            comicsRepo = ComicBookFactory.CreateComicBookRepo();
        }
     
        private void frmComics_Load(object sender, System.EventArgs e)
        {
            SetDGV();
        }

        public void SetDGV()
        {
            dgvComics.DataSource = comicsRepo.GetComicBooks();
        }

    }
}
