using ComicBookFactories;
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
    public partial class frmPersonnels : Form
    {
        IPersonnelRepo personnelRepo;
        public frmPersonnels()
        {
            InitializeComponent();
            personnelRepo = PersonnelFactory.CreatePersonnelRepo();
        }

        private void frmPersonnel_Load(object sender, EventArgs e)
        {
            SetDGV();
        }
        private void SetDGV()
        {
            dgvPersonnel.DataSource = personnelRepo.GetPersonnelList();
        }
    }
}
