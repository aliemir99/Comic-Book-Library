using ComicBookFactories;
using ComicBookLibrary.Utilities;
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

namespace ComicBookLibrary.Manage_Forms
{
    public partial class frmManageComicBooks : Form
    {

        private FormState currentState;
        private int currentComicID = 0;
        private int firstComicID = 0;
        private int lastComicID = 0;
        private int? previousComicID;
        private int? nextComicID;
        private IComicBookRepo comicsRepo;
        private IPersonnelRepo personnelRepo;
        private ComicBook tmpComic;
        private sqlPreFilledTables dataFiller;
        

        public frmManageComicBooks()
        {
            InitializeComponent();
            dataFiller = new sqlPreFilledTables();
        }

        private void ManageComicBooks_Load(object sender, EventArgs e)
        {
            comicsRepo = ComicBookFactory.CreateComicBookRepo();
            personnelRepo = PersonnelFactory.CreatePersonnelRepo();
            //load necessary combo boxes
            LoadGenres();
            LoadRatings();
            LoadPublishers();
            LoadPersonnels();

            LoadFirstComic();

        }
        private void LoadGenres()
        {
            var dt = dataFiller.getGenresTable();
            UIUtilities.BindComboBox(cmbGenres, dt, dt.Columns[1].ToString(), dt.Columns[0].ToString());
        }
        private void LoadRatings()
        {
            var dt = dataFiller.getRatingsTable();
            UIUtilities.BindComboBox(cmbRatings, dt, dt.Columns[1].ToString(), dt.Columns[0].ToString());
        }
        private void LoadPublishers()
        {
            var dt = dataFiller.getPublishersTable();
            UIUtilities.BindComboBox(cmbPublisher, dt, dt.Columns[1].ToString(), dt.Columns[0].ToString());
        }
        private void LoadPersonnels()
        {
            var dt1 = personnelRepo.GetPersonnelsTable();
            UIUtilities.BindComboBox(cmbAuthor, dt1, dt1.Columns[1].ToString(), dt1.Columns[0].ToString());

            var dt2 = personnelRepo.GetPersonnelsTable();
            UIUtilities.BindComboBox(cmbDesigner, dt2, dt2.Columns[1].ToString(), dt2.Columns[0].ToString());
        }

        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btnFirst":
                    currentComicID = firstComicID;
                    break;
                case "btnLast":
                    currentComicID = lastComicID;
                    break;
                case "btnPrevious":
                    currentComicID = previousComicID.Value;
                    break;
                case "btnNext":
                    currentComicID = nextComicID.Value;
                    break;
            }
            LoadComicDetails(currentComicID);
            NextPreviousButtonManagement();
        }
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousComicID != null;
            btnNext.Enabled = nextComicID != null;
        }
        private void LoadComicDetails(int comicID)
        {
            try
            {
                var ds = comicsRepo.GetComicDetailDataSet(comicID);

                var dtPersonnel = ds.Tables[0];
                var dtSequenceDetails = ds.Tables[1];

                if (dtPersonnel.Rows.Count == 1)
                {
                    LoadComicDetails(dtPersonnel.Rows[0]);
                    LoadComicSequenceDetail(dtSequenceDetails.Rows[0]);
                }
                else
                {
                    MessageBox.Show("The Comic Book no longer exists");
                    LoadFirstComic();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void LoadFirstComic()
        {
            try
            {
                firstComicID = comicsRepo.GetFirstComicID();
                currentComicID = firstComicID;
                LoadComicDetails(firstComicID);
                NextPreviousButtonManagement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadComicSequenceDetail(DataRow dataRow)
        {
            firstComicID = Convert.ToInt32(dataRow["firstComicID"]);
            previousComicID = dataRow["previousComicID"] !=
                DBNull.Value ? Convert.ToInt32(dataRow["previousComicID"]) : (int?)null;
            nextComicID = dataRow["nextComicID"] !=
                DBNull.Value ? Convert.ToInt32(dataRow["nextComicID"]) : (int?)null;
            lastComicID = Convert.ToInt32(dataRow["lastComicID"]);
        }

        private void LoadComicDetails(DataRow selectedComic)
        {
            txtName.Text = selectedComic["BookName"].ToString();
            txtDescription.Text = selectedComic["BookDescription"].ToString();
            dtpPublishDate.Value = (DateTime)selectedComic["PublishDate"];

            cmbGenres.SelectedValue = selectedComic["GenreID"];
            cmbRatings.SelectedValue = selectedComic["RatingID"];

            cmbAuthor.SelectedValue = selectedComic["Author"];
            cmbDesigner.SelectedValue = selectedComic["Designer"];
            

            cmbPublisher.SelectedValue = selectedComic["PublisherID"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UIUtilities.ClearControls(this.grpComicBook.Controls);
            UIUtilities.ClearControls(this.grpCollaborator.Controls);
            UIUtilities.ClearControls(this.grpPublisher.Controls);

            btnSave.Text = "Create";
            setCurrentState(FormState.Add);

            NavigationState(false);
        }

        private void setCurrentState(FormState formState)
        {
            currentState = formState;
            LoadCurrentState(formState);
        }

        private void LoadCurrentState(FormState formState)
        {
            switch (formState)
            {
                case FormState.View:
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = true;
                    break;

                case FormState.Add:
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    break;

            }
        }
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                comicsRepo.Delete(currentComicID);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            MessageBox.Show("Comic Book Has Been Deleted");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tmpComic = new ComicBook();
            List<string> errors = new List<string>();
            if (btnSave.Text == "Create")
            {
                LoadComicFromForm(tmpComic);
                errors = ComicBookExtension.Validate(tmpComic);
                if(errors.Count > 0)
                    MessageBox.Show(DisplayErrors(errors));
                else
                    comicsRepo.Create(tmpComic);

            }
            else if (btnSave.Text == "Save")
            {
                LoadComicFromForm(tmpComic);
                errors = ComicBookExtension.Validate(tmpComic);
                if (errors.Count > 0)
                    MessageBox.Show(DisplayErrors(errors));
                else
                    comicsRepo.Save(tmpComic);

            }

            NavigationState(true);
        }

        private string DisplayErrors(List<string> errors)
        {
            string errorMsg = "";
            foreach(string error in errors)
            {
                errorMsg += error + "\n";   
            }
            return errorMsg;
        }

        private void LoadComicFromForm(ComicBook comic)
        {
            if (btnSave.Text == "Save")
                comic.BookID = currentComicID;

            comic.Name = txtName.Text.ToString();
            comic.Description = txtDescription.Text.ToString();
            comic.PublishDate = dtpPublishDate.Value;
            comic.Author = cmbAuthor.SelectedValue.ToString();
            comic.Designer = cmbDesigner.SelectedValue.ToString();
            comic.GenreID = cmbGenres.SelectedValue.ToString();
            comic.RatingID = cmbRatings.SelectedValue.ToString();
            comic.PublisherID = cmbPublisher.SelectedValue.ToString();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadComicDetails(currentComicID);

            btnSave.Text = "Save";
            setCurrentState(FormState.View);

            NavigationState(true);
            NextPreviousButtonManagement();
        }
    }
}
