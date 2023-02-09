using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AspLoginForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-P8FARIT\SQLEXPRESS; Initial Catalog = loginUserAccount; Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            //Reference Video = https://youtu.be/AvrQS6df7L8 for login form
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from userAccountTable where UserName = ' "+ txtUserName.Text +" ' and Password = ' "+ txtPassword.Text + " ' " , sqlCon);
            //from here we put validations
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You're Successfully login to the system!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Invalid UserName or Password!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}