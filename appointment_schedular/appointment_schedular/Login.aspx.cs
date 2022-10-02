using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace appointment_schedular
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    
        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string checkUser = "select count(*) from UserData where Username='" + TextBoxUserName.Text + "'  ";
                SqlCommand com = new SqlCommand(checkUser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();

                if (temp == 1)
                {
                    conn.Open();
                    string checkPasswordQuery = "select Password from UserData where Username ='" + TextBoxUserName.Text + "' ";
                    SqlCommand passcom = new SqlCommand(checkPasswordQuery, conn);
                    string password = passcom.ExecuteScalar().ToString().Replace(" ","");
                    if(password  == TextBoxPassword.Text)
                    {
                        string name = TextBoxUserName.Text.Trim();
                        Session["name"] = TextBoxUserName.Text;
                        //Response.Write("Password is correct");
                        Response.Redirect("ViewAppointment.aspx");
                    }
                    else
                    {
                        Response.Write("Password is not correct");
                    }
                }
                else
                {
                    Response.Write("Please enter valid User name");
                }


            }
        }
    }
}