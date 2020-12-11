using ComicBookFactories;
using System;
using System.Windows.Forms;
using VideoGameMaintenance;

namespace ComicBookLibrary
{
    public partial class frmLogin : Form
    {
        private ILoginRepo loginRepo;
        public frmLogin()
        {
            InitializeComponent();
            Application.Run(new SplashScreen());
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            loginRepo = LoginFactory.createLoginRepo();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "Register";
            btnRegister.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text.Equals("Register"))
            {
                try
                {
                   loginRepo.RegisterUser(txtUsername.Text, txtPassword.Text);
                }
                catch(System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                MessageBox.Show("User successfully Registered");
                //register the user then flip the button functionality.
                btnLogin.Text = "Login";
                btnRegister.Visible = true;
            }
            if (btnLogin.Text.Equals("Login"))
            {
                //check if the credentials match in the database and login accordingly.
                var rowsAffected = 0 ;
                try
                {
                    rowsAffected = loginRepo.LoginUser(txtUsername.Text, txtPassword.Text);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                if (rowsAffected == 1)
                {
                    MessageBox.Show("User successfully Logged in");
                    Hide();
                    new mdiComics().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

      
    }
}
