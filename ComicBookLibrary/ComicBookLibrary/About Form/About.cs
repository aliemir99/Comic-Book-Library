using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookLibrary.About_Form
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            txtDescription.Text = "Comic Book Library application made by Ali Emir Samlioglu " + System.Environment.NewLine +
                "This application was made for the purpose of Final Database Programming project." +
                "Product features the ability to add comic books and add personnel as well as managing" +
                "your entries within the database. The product comes with a login page that requires you" +
                "to register at initial launch of the application. " + System.Environment.NewLine + 
                "All rights of this application are reserved " +
                "by Ali Emir Samlioglu. ";
        }
    }
}
