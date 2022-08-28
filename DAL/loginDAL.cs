using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsABCD.BLL;

namespace WindowsABCD.DAL
{
    class loginDAL
    {
        //Static String to connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
        public bool loginCheck(loginBLL l)
        {
            // Create a boolean variable and set its value to false and return it
            bool isSuccess = false;
            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to check login
                string sql = "SELECT * from tbl_users where username = @username and password = @password And user_type = @user_type";
                //Creating SQL Command to pass login
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    //login successful
                    isSuccess = true;

                }
                else
                {
                    //Login fail
                    isSuccess = false;
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
