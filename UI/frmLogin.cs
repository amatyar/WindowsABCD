using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsABCD.BLL;
using WindowsABCD.DAL;

namespace WindowsABCD.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
       
        public static string loggedIn;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //Checking the login credentials
            bool success = dal.loginCheck(l);
            if (success==true)
            {

                //Login succesful
                MessageBox.Show("Login Succesful.");
                loggedIn = l.username;
                //To open respective forms based on userType
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            //For Display Adminstration Dashboard
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            //For Display User Dashboard
                            frmUserDashboards user = new frmUserDashboards();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            //Display an error message
                            MessageBox.Show("Invalid user Type.");
                        }
                        break;
                }

            }
            else
            {
                //Login failed
                MessageBox.Show("Login Failed.");
            }
        }
    }
}
