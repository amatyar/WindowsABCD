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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

         private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgv.DataSource = dt;

        }
        private void clear()
        {
            txtuserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            comboBoxgender.Text = "";
            comboBoxuserType.Text = "";

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txtuserID.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgv.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgv.Rows[rowIndex].Cells[4].Value.ToString();
            txtpassword.Text = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            txtcontact.Text = dgv.Rows[rowIndex].Cells[6].Value.ToString();
            txtaddress.Text = dgv.Rows[rowIndex].Cells[7].Value.ToString();
            comboBoxgender.Text = dgv.Rows[rowIndex].Cells[8].Value.ToString();
            comboBoxuserType.Text = dgv.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            

            //Getting Data from UI
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtpassword.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.gender = comboBoxgender.Text;
            u.user_type = comboBoxuserType.Text;
            u.added_date = DateTime.Now;

            //Getting usernameof the logged in user
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.ID;

            //Inserting Data into Database
            bool success = dal.Insert(u);

            //if the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                MessageBox.Show("User successfully created");

            }
            else
            {
                MessageBox.Show("Failed to add new User");
            }
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgv.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //Get the value from User UI
            u.ID = Convert.ToInt32(txtuserID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtpassword.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.gender = comboBoxgender.Text;
            u.user_type = comboBoxuserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            //updating Data into Database
            bool success = dal.Update(u);
            //if data is updated succesfully then the value of success will be true else it will be false
            if(success == true)
            {
                //Data updated successfully
                MessageBox.Show("User successfully updated");
                clear();
            }
            else
            {
                //Failed to update user
                MessageBox.Show("Failed to update user");
            }

            
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgv.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Getting user ID from Form
            u.ID = Convert.ToInt32(txtuserID.Text);

            bool success = dal.Delete(u);
            // If data is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                //user deleted successfully
                MessageBox.Show("User successfully deleted");
                clear();
            }
            else
            {
                //Failed to delete user
                MessageBox.Show("Failed to update user");

            }
            
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgv.DataSource = dt;
        }

      

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            //Get keyword from textbox
            string keywords = txtSearch.Text;
            //Check if the keyword hasvalue or not
            if (keywords != null)
            {
                // show user based on keywords
                DataTable dt = dal.Search(keywords);
                dgv.DataSource = dt;
            }
            else
            {
                //show all user from the database
                DataTable dt = dal.Select();
                dgv.DataSource = dt;
            }
        }
    }
}
