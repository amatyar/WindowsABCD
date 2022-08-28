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
    class userDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;

        #region select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                //Sql Query to get Data from Database
                String sql = "Select * from tbl_users";
                //For executing Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting data from Database
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                //Database connection Open
                conn.Open();
                //Fill Data in our Datatable

                ad.Fill(dt);
            }
            catch(Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;
        }

        #endregion
        #region Insert Data in Database
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String Sql = "Insert Into tbl_users(first_name, last_name, email,username, password, contact, address, gender, user_type, added_date, added_by) Values(@first_name, @last_name, @email,@username, @password, @contact, @address, @gender, @user_type, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;
                }
                else
                {
                    //Query Fail
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
        #endregion

        #region Update data in Database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name, last_name=@last_name , email = @email, password = @password, contact = @contact, address = @address, gender = @gender, user_type = @user_type, added_date = @added_date, added_by = @added_by";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.ID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
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
        #endregion

        #region Delete Data from Database
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "Delete from tbl_users where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", u.ID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
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

        #endregion

        #region select Data from Database using keywords
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                //Sql Query to get Data from Database
                String sql = "Select * from tbl_users where id LIKE '%"+keywords+"%' OR first_name LIKE '%"+keywords+ "%' OR last_name LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%' ";
                //For executing Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Getting data from Database
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                //Database connection Open
                conn.Open();
                //Fill Data in our Datatable

                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;
        }
        #endregion

        #region Getting user ID from Username
        public userBLL GetIDFromUsername (string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select id from tbl_users where username='" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    u.ID = int.Parse(dt.Rows[0]["id"].ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                conn.Close();
            }
            return u;
        }

        #endregion
    }
}
