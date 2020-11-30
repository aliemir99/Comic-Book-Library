using ComicBookFactories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM = System.Configuration.ConfigurationManager;
namespace ComicBookLibrary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataAccess.DataAccess.connectionString = CM.ConnectionStrings["ComicBookCatalog"].ConnectionString;
            ComicBookFactory.ComicBookRepoFunc = (() => new SqlComicBook());
            PersonnelFactory.PersonnelRepoFunc = (() => new SqlPersonnel());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiComics());
        }
    }
}
