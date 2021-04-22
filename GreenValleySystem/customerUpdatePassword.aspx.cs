using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Security.Cryptography;

namespace GreenValleySystem
{
    public partial class customerUpdatePassword : System.Web.UI.Page
    {
        string strConnString = WebConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        string str = null;
        SqlCommand com;
        byte up;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            str = "SELECT customerauth.PasswordHash, customer.customerID, customer.firstName + ' ' + customer.lastName as custName FROM Customer Inner join customerauth on " +
                    "customer.customerID = customerauth.customerID";
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string storedHash = reader["PasswordHash"].ToString();
                if (PasswordHash.ValidatePassword(txtPassword.Text, storedHash)) // if the entered password matches what is stored, it will show success
                {
                    Session["customerID"] = reader["customerID"];
                    up = 1;
                }
            }
            reader.Close();
            con.Close();
            if (up == 1)
            {
                con.Open();
                str = "UPDATE customerauth set PasswordHash=@PasswordHash where customerID='" + Session["customerID"].ToString() + "'";
                com = new SqlCommand(str, con);
                com.Parameters.Add(new SqlParameter("@PasswordHash", PasswordHash.HashPassword(txtPassword1.Text)));
                com.ExecuteNonQuery();
                con.Close();

            

                lblMessage.Text = "Password successfully changed!";
            }
            else
            {
                lblMessage.Text = "Current password is invalid!";
            }
        }
    }
}