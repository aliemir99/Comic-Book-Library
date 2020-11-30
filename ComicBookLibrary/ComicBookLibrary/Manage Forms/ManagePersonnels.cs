using ComicBookFactories;
using ComicBookLibrary.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace ComicBookLibrary.Manage_Forms
{
    public partial class frmManagePersonnels : Form
    {
        private FormState currentState;

        private int currentPersonnelID = 0;
        private int firstPersonnelID = 0;
        private int lastPersonnelID= 0;
        private int? previousPersonnelID;
        private int? nextPersonnelID;
        IPersonnelRepo personnelRepo;
        Personnel tmpPersonnel;

        public frmManagePersonnels()
        {
            InitializeComponent();
        }

        private void frmManagePersonnels_Load(object sender, EventArgs e)
        {
            //load fields with the first personnel
            personnelRepo = PersonnelFactory.CreatePersonnelRepo();
            LoadFirstPersonnel();
        }
        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btnFirst":
                    currentPersonnelID = firstPersonnelID;
                    break;
                case "btnLast":
                    currentPersonnelID = lastPersonnelID;
                    break;
                case "btnPrevious":
                    currentPersonnelID = previousPersonnelID.Value;
                    break;
                case "btnNext":
                    currentPersonnelID = nextPersonnelID.Value;
                    break;
            }
            LoadPersonnelDetails(currentPersonnelID); 
            NextPreviousButtonManagement();
        }
        private void LoadPersonnelDetails(int PersonnelId)
        {
            try
            {
                var ds = personnelRepo.GetPersonnelDetailDataSet(PersonnelId);

                var dtPersonnel = ds.Tables[0];
                var dtSequenceDetails = ds.Tables[1];

                if (dtPersonnel.Rows.Count == 1)
                {
                    LoadPersonnelDetails(dtPersonnel.Rows[0]);
                    LoadPersonnelSequenceDetail(dtSequenceDetails.Rows[0]);
                }
                else
                {
                    MessageBox.Show("The Personnel no longer exists");
                    LoadFirstPersonnel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadPersonnelSequenceDetail(DataRow dataRow)
        {
            firstPersonnelID = Convert.ToInt32(dataRow["firstPersonnelID"]);
            previousPersonnelID = dataRow["previousPersonnelID"] !=
                DBNull.Value ? Convert.ToInt32(dataRow["previousPersonnelID"]) : (int?)null;
            nextPersonnelID = dataRow["nextPersonnelID"] !=
                DBNull.Value ? Convert.ToInt32(dataRow["nextPersonnelID"]) : (int?)null;
            lastPersonnelID = Convert.ToInt32(dataRow["lastPersonnelID"]);
        }

        private void LoadPersonnelDetails(DataRow selectedPersonnel)
        {
            txtFName.Text = selectedPersonnel["FirstName"].ToString();
            txtLName.Text = selectedPersonnel["LastName"].ToString();
            dtpBirthDate.Text = selectedPersonnel["DateOfBirth"].ToString();
        }
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }
        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousPersonnelID != null;
            btnNext.Enabled = nextPersonnelID != null;
        }


        private void LoadFirstPersonnel()
        {
            try
            {
                
                firstPersonnelID = personnelRepo.GetFirstPersonnelID();
                currentPersonnelID = firstPersonnelID;
                LoadPersonnelDetails(firstPersonnelID);
                NextPreviousButtonManagement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           UIUtilities.ClearControls(this.grpPersonnel.Controls);
            
            btnSave.Text = "Create";
            setCurrentState(FormState.Add);

            NavigationState(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                personnelRepo.Delete(currentPersonnelID);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            MessageBox.Show("Personnel Has Been Deleted");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tmpPersonnel = new Personnel();
            if (btnSave.Text == "Create")
            {
                LoadPersonnelFromForm(tmpPersonnel);
                personnelRepo.Create(tmpPersonnel);
            }
            else if (btnSave.Text == "Save")
            {
                LoadPersonnelFromForm(tmpPersonnel);
                personnelRepo.Save(tmpPersonnel);
            }
            else
                MessageBox.Show("The database reported no rows affected");

            NavigationState(true);
        }
        private void LoadPersonnelFromForm(Personnel personnel)
        {
            if (btnSave.Text == "Save")
                personnel.PersonnelID = currentPersonnelID;

            personnel.FirstName = txtFName.Text.ToString();
            personnel.LastName = txtLName.Text.ToString();
            personnel.DateOfBirth = dtpBirthDate.Value;
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadPersonnelDetails(currentPersonnelID);

            btnSave.Text = "Save";
            setCurrentState(FormState.View);


            NavigationState(true);
            NextPreviousButtonManagement();
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
    }
}
