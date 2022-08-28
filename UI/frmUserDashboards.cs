using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsABCD.UI;

namespace WindowsABCD
{
    public partial class frmUserDashboards : Form
    {
        public frmUserDashboards()
        {
            InitializeComponent();
        }

        private void frmUserDashboards_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmUserDashboards_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedIn;
        }
    }
}
