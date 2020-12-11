using System;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
  * Name : Ali Emir Samlioglu
  * Date : 2020-10-19
  * Purpose : Video Game Library Assignment
 */
namespace VideoGameMaintenance
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void LoadSplash_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(100);
                for (int i = 0; i <= 100; i += 1)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        pbLoading.Value = i;
                        System.Threading.Thread.Sleep(50);
                        pbLoading.Refresh();
                    });
                }
            }).ContinueWith((x) => {
                this.Invoke((MethodInvoker)delegate
                { this.Close(); });
            });
        }
    }
}

